FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/NutNull.Practice.Web.Host/NutNull.Practice.Web.Host.csproj", "src/NutNull.Practice.Web.Host/"]
COPY ["src/NutNull.Practice.Web.Core/NutNull.Practice.Web.Core.csproj", "src/NutNull.Practice.Web.Core/"]
COPY ["src/NutNull.Practice.Application/NutNull.Practice.Application.csproj", "src/NutNull.Practice.Application/"]
COPY ["src/NutNull.Practice.Core/NutNull.Practice.Core.csproj", "src/NutNull.Practice.Core/"]
COPY ["src/NutNull.Practice.EntityFrameworkCore/NutNull.Practice.EntityFrameworkCore.csproj", "src/NutNull.Practice.EntityFrameworkCore/"]
WORKDIR "/src/src/NutNull.Practice.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/NutNull.Practice.Web.Host", "src/NutNull.Practice.Web.Host"]
COPY ["src/NutNull.Practice.Web.Core", "src/NutNull.Practice.Web.Core"]
COPY ["src/NutNull.Practice.Application", "src/NutNull.Practice.Application"]
COPY ["src/NutNull.Practice.Core", "src/NutNull.Practice.Core"]
COPY ["src/NutNull.Practice.EntityFrameworkCore", "src/NutNull.Practice.EntityFrameworkCore"]
WORKDIR "/src/src/NutNull.Practice.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "NutNull.Practice.Web.Host.dll"]
