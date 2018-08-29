FROM microsoft/dotnet:2.0 AS base
WORKDIR /app

FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /src
COPY Caller.Worker/Caller.Worker.csproj Caller.Worker/
RUN dotnet restore Caller.Worker/Caller.Worker.csproj
COPY . .
WORKDIR /src/Caller.Worker
RUN dotnet build Caller.Worker.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Caller.Worker.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Caller.Worker.dll"]
