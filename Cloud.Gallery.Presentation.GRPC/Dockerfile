FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cloud.Galery.Core/Cloud.Galery.Core.csproj", "Cloud.Galery.Core/"]
RUN dotnet restore "Cloud.Galery.Core/Cloud.Galery.Core.csproj"
COPY . .
WORKDIR "/src/Cloud.Galery.Core"
RUN dotnet build "Cloud.Galery.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cloud.Galery.Core.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cloud.Galery.Core.dll"]
