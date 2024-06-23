#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/dockerExample.HttpApi.Host/dockerExample.HttpApi.Host.csproj", "src/dockerExample.HttpApi.Host/"]
COPY ["src/dockerExample.Application/dockerExample.Application.csproj", "src/dockerExample.Application/"]
COPY ["src/dockerExample.Domain/dockerExample.Domain.csproj", "src/dockerExample.Domain/"]
COPY ["src/dockerExample.Domain.Shared/dockerExample.Domain.Shared.csproj", "src/dockerExample.Domain.Shared/"]
COPY ["src/dockerExample.Application.Contracts/dockerExample.Application.Contracts.csproj", "src/dockerExample.Application.Contracts/"]
COPY ["src/dockerExample.EntityFrameworkCore/dockerExample.EntityFrameworkCore.csproj", "src/dockerExample.EntityFrameworkCore/"]
COPY ["src/dockerExample.HttpApi/dockerExample.HttpApi.csproj", "src/dockerExample.HttpApi/"]
RUN dotnet restore "./src/dockerExample.HttpApi.Host/dockerExample.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/dockerExample.HttpApi.Host"
RUN dotnet build "./dockerExample.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./dockerExample.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ConnectionStrings__Default="Host=postgres;Port=5432;Database=dockerExample;Username=postgres;Password=postgres;"

ENTRYPOINT ["dotnet", "dockerExample.HttpApi.Host.dll"]