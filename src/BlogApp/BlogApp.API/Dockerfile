#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlogApp.API/BlogApp.API.csproj", "BlogApp.API/"]
RUN dotnet restore "BlogApp.API/BlogApp.API.csproj"
COPY . .
WORKDIR "/src/BlogApp.API"
RUN dotnet build "BlogApp.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlogApp.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlogApp.API.dll"]