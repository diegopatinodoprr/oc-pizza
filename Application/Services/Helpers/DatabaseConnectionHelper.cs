using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Polly;
using Polly.Retry;

namespace Helpers
{
    public class DatabaseConnectionHelper
    {
        public static RetryPolicy BuildWaitAndRetryForDatabaseConnection(string databaseLastRetryInSeconds)
        {
            double lastRetryTimeInSeconds = 30;
            var lastRetryTimeInSecondsAsString = Environment.GetEnvironmentVariable(databaseLastRetryInSeconds);
            if (!string.IsNullOrWhiteSpace(lastRetryTimeInSecondsAsString))
            {
                double.TryParse(lastRetryTimeInSecondsAsString, out lastRetryTimeInSeconds);
            }

            var waitAndRetry = Policy
                .Handle<DbException>()
                .WaitAndRetry(new[]
                {
                    TimeSpan.FromSeconds(5),
                    TimeSpan.FromSeconds(10),
                    TimeSpan.FromSeconds(lastRetryTimeInSeconds)
                });
            return waitAndRetry;
        }
    }
}
