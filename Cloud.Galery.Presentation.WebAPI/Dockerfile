FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Cloud.Galery.Presentation.WebAPI/Cloud.Galery.Presentation.WebAPI.csproj", "Cloud.Galery.Presentation.WebAPI/"]
RUN dotnet restore "Cloud.Galery.Presentation.WebAPI/Cloud.Galery.Presentation.WebAPI.csproj"
COPY . .
WORKDIR "/src/Cloud.Galery.Presentation.WebAPI"
RUN dotnet build "Cloud.Galery.Presentation.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cloud.Galery.Presentation.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cloud.Galery.Presentation.WebAPI.dll"]
