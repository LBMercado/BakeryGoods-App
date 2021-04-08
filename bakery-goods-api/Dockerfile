FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["bakery-goods-api/bakery-goods-api.csproj", "bakery-goods-api/"]
RUN dotnet restore "bakery-goods-api/bakery-goods-api.csproj"
COPY . .
WORKDIR "/src/bakery-goods-api"
RUN dotnet build "bakery-goods-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bakery-goods-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bakery-goods-api.dll"]
