using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using NLog;

namespace Helpers
{
    public class ErrorHandlingMiddleware
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger logger, IHostingEnvironment hostingEnvironment)
        {
            _next = next;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError; // 500 if unexpected

            if (exception is BaseException)
            {
                if (exception is DomainException || exception is CustomerIdNotValidException)
                    code = HttpStatusCode.BadRequest;

                if (exception is ResourceNotFoundException) code = HttpStatusCode.NotFound;
                _logger.Warn(exception);
                LogInnerException(exception, LogLevel.Warn);
            }
            else
            {
                _logger.Error(exception);
                LogInnerException(exception, LogLevel.Error);
            }

            context.Response.StatusCode = (int) code;

            if (_hostingEnvironment.IsDevelopment() || _hostingEnvironment.IsStaging())
            {
                var result = JsonConvert.SerializeObject(new {error = exception.Message});
                context.Response.ContentType = "application/json";
                return context.Response.WriteAsync(result);
            }

            return context.Response.WriteAsync("Server error");
        }

        private void LogInnerException(Exception exception, LogLevel logLevel)
        {
            if (exception.InnerException != null)
            {
                _logger.Log(logLevel, exception.InnerException);
                LogInnerException(exception.InnerException, logLevel);
            }
        }
    }

    public class ResourceNotFoundException : ApplicationException
    {
        public ResourceNotFoundException(string resourceName) : base($"{resourceName} not found")
        {
        }

        public ResourceNotFoundException(string resourceName, Exception innerException) : base(
            $"{resourceName} not found", innerException)
        {
        }
    }
}