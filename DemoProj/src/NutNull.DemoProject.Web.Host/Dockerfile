FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/NutNull.DemoProject.Web.Host/NutNull.DemoProject.Web.Host.csproj", "src/NutNull.DemoProject.Web.Host/"]
COPY ["src/NutNull.DemoProject.Web.Core/NutNull.DemoProject.Web.Core.csproj", "src/NutNull.DemoProject.Web.Core/"]
COPY ["src/NutNull.DemoProject.Application/NutNull.DemoProject.Application.csproj", "src/NutNull.DemoProject.Application/"]
COPY ["src/NutNull.DemoProject.Core/NutNull.DemoProject.Core.csproj", "src/NutNull.DemoProject.Core/"]
COPY ["src/NutNull.DemoProject.EntityFrameworkCore/NutNull.DemoProject.EntityFrameworkCore.csproj", "src/NutNull.DemoProject.EntityFrameworkCore/"]
WORKDIR "/src/src/NutNull.DemoProject.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/NutNull.DemoProject.Web.Host", "src/NutNull.DemoProject.Web.Host"]
COPY ["src/NutNull.DemoProject.Web.Core", "src/NutNull.DemoProject.Web.Core"]
COPY ["src/NutNull.DemoProject.Application", "src/NutNull.DemoProject.Application"]
COPY ["src/NutNull.DemoProject.Core", "src/NutNull.DemoProject.Core"]
COPY ["src/NutNull.DemoProject.EntityFrameworkCore", "src/NutNull.DemoProject.EntityFrameworkCore"]
WORKDIR "/src/src/NutNull.DemoProject.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "NutNull.DemoProject.Web.Host.dll"]
