FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/NutNull.Ojt.Web.Host/NutNull.Ojt.Web.Host.csproj", "src/NutNull.Ojt.Web.Host/"]
COPY ["src/NutNull.Ojt.Web.Core/NutNull.Ojt.Web.Core.csproj", "src/NutNull.Ojt.Web.Core/"]
COPY ["src/NutNull.Ojt.Application/NutNull.Ojt.Application.csproj", "src/NutNull.Ojt.Application/"]
COPY ["src/NutNull.Ojt.Core/NutNull.Ojt.Core.csproj", "src/NutNull.Ojt.Core/"]
COPY ["src/NutNull.Ojt.EntityFrameworkCore/NutNull.Ojt.EntityFrameworkCore.csproj", "src/NutNull.Ojt.EntityFrameworkCore/"]
WORKDIR "/src/src/NutNull.Ojt.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/NutNull.Ojt.Web.Host", "src/NutNull.Ojt.Web.Host"]
COPY ["src/NutNull.Ojt.Web.Core", "src/NutNull.Ojt.Web.Core"]
COPY ["src/NutNull.Ojt.Application", "src/NutNull.Ojt.Application"]
COPY ["src/NutNull.Ojt.Core", "src/NutNull.Ojt.Core"]
COPY ["src/NutNull.Ojt.EntityFrameworkCore", "src/NutNull.Ojt.EntityFrameworkCore"]
WORKDIR "/src/src/NutNull.Ojt.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "NutNull.Ojt.Web.Host.dll"]
