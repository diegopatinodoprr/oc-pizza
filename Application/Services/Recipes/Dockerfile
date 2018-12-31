# escape=`
FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5008

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src

COPY /Services/ /Services/

WORKDIR /Services/Recipes/
RUN dotnet restore -nowarn:msb3202,nu1503

RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Recipes.dll"]