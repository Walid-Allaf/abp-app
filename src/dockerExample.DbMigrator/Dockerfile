FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# نسخ ملفات المشروع
COPY ["src/dockerExample.DbMigrator/dockerExample.DbMigrator.csproj", "src/dockerExample.DbMigrator/"]
COPY ["src/dockerExample.Application/dockerExample.Application.csproj", "src/dockerExample.Application/"]
COPY ["src/dockerExample.Domain/dockerExample.Domain.csproj", "src/dockerExample.Domain/"]
COPY ["src/dockerExample.Domain.Shared/dockerExample.Domain.Shared.csproj", "src/dockerExample.Domain.Shared/"]
COPY ["src/dockerExample.Application.Contracts/dockerExample.Application.Contracts.csproj", "src/dockerExample.Application.Contracts/"]
COPY ["src/dockerExample.EntityFrameworkCore/dockerExample.EntityFrameworkCore.csproj", "src/dockerExample.EntityFrameworkCore/"]
COPY ["src/dockerExample.HttpApi/dockerExample.HttpApi.csproj", "src/dockerExample.HttpApi/"]
COPY . .

# استعادة التبعيات
WORKDIR /app/src/dockerExample.DbMigrator
RUN dotnet restore

# بناء المشروع
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/src/dockerExample.DbMigrator/out .

# تعيين المتغيرات البيئية للاتصال بقاعدة البيانات
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ConnectionStrings__Default="Host=postgres;Port=5432;Database=dockerExample;Username=postgres;Password=postgres;"

ENTRYPOINT ["dotnet", "dockerExample.DbMigrator.dll"]
