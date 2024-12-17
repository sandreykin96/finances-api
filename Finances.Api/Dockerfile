#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Finances.Api/Finances.Api.csproj", "Finances.Api/"]
COPY ["Finances.Dal/Finances.Dal.csproj", "Finances.Dal/"]
COPY ["Finances.Bll/Finances.Bll.csproj", "Finances.Bll/"]
RUN dotnet restore "Finances.Api/Finances.Api.csproj"
COPY . .
WORKDIR "/src/Finances.Api"
RUN dotnet build "Finances.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Finances.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Finances.Api.dll"]
