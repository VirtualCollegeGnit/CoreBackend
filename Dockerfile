#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["core.api/core.api.csproj", "core.api/"]
COPY ["core.data/core.data.csproj", "core.data/"]
COPY ["core.logic/core.logic.csproj", "core.logic/"]
RUN dotnet restore "core.api/core.api.csproj"
COPY . .
WORKDIR "/src/core.api"
RUN dotnet build "core.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "core.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS="http://*:$PORT" HEROKU_POSTGRES="$POSTGRES" dotnet core.api.dll
# ENTRYPOINT ["dotnet", "core.api.dll"]