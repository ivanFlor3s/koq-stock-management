FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["KoqStockManagement.Api/KoqStockManagement.Api.csproj", "KoqStockManagement.Api/"]
COPY ["KoqStockManagement.Application/KoqStockManagement.Application.csproj", "KoqStockManagement.Application/"]
COPY ["KoqStockManagement.Domain/KoqStockManagement.Domain.csproj", "KoqStockManagement.Domain/"]
COPY ["KoqStockManagement.Infrastructure/KoqStockManagement.Infrastructure.csproj", "KoqStockManagement.Infrastructure/"]
RUN dotnet restore "KoqStockManagement.Api/KoqStockManagement.Api.csproj"
COPY . .
WORKDIR "/src/KoqStockManagement.Api"
RUN dotnet build "KoqStockManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KoqStockManagement.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KoqStockManagement.Api.dll"]
