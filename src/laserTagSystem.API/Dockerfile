FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/laserTagSystem.API/laserTagSystem.API.csproj", "src/laserTagSystem.API/"]
RUN dotnet restore "src/laserTagSystem.API/laserTagSystem.API.csproj"
COPY . .
WORKDIR "/src/src/laserTagSystem.API"
RUN dotnet build "./laserTagSystem.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./laserTagSystem.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "laserTagSystem.API.dll"]
