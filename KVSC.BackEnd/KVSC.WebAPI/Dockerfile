#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["KVSC.WebAPI/KVSC.WebAPI.csproj", "KVSC.WebAPI/"]
COPY ["KVSC.Application/KVSC.Application.csproj", "KVSC.Application/"]
COPY ["KVSC.Domain/KVSC.Domain.csproj", "KVSC.Domain/"]
COPY ["KVSC.Infrastructure/KVSC.Infrastructure.csproj", "KVSC.Infrastructure/"]
RUN dotnet restore "./KVSC.WebAPI/KVSC.WebAPI.csproj"
COPY . .
WORKDIR "/src/KVSC.WebAPI"
RUN dotnet build "./KVSC.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./KVSC.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KVSC.WebAPI.dll"]