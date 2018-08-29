FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Responder.Api/Responder.Api.csproj Responder.Api/
RUN dotnet restore Responder.Api/Responder.Api.csproj
COPY . .
WORKDIR /src/Responder.Api
RUN dotnet build Responder.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Responder.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Responder.Api.dll"]
