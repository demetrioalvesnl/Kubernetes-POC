FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Caller.Api/Caller.Api.csproj Caller.Api/
RUN dotnet restore Caller.Api/Caller.Api.csproj
COPY . .
WORKDIR /src/Caller.Api
RUN dotnet build Caller.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Caller.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Caller.Api.dll"]
