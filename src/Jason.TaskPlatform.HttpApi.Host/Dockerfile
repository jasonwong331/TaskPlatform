#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/Jason.TaskPlatform.HttpApi.Host/Jason.TaskPlatform.HttpApi.Host.csproj", "src/Jason.TaskPlatform.HttpApi.Host/"]
COPY ["src/Jason.TaskPlatform.HttpApi/Jason.TaskPlatform.HttpApi.csproj", "src/Jason.TaskPlatform.HttpApi/"]
COPY ["src/Jason.TaskPlatform.Application.Contracts/Jason.TaskPlatform.Application.Contracts.csproj", "src/Jason.TaskPlatform.Application.Contracts/"]
COPY ["src/Jason.TaskPlatform.Domain.Shared/Jason.TaskPlatform.Domain.Shared.csproj", "src/Jason.TaskPlatform.Domain.Shared/"]
COPY ["src/Jason.TaskPlatform.EntityFrameworkCore/Jason.TaskPlatform.EntityFrameworkCore.csproj", "src/Jason.TaskPlatform.EntityFrameworkCore/"]
COPY ["src/Jason.TaskPlatform.Domain/Jason.TaskPlatform.Domain.csproj", "src/Jason.TaskPlatform.Domain/"]
COPY ["src/Jason.TaskPlatform.Application/Jason.TaskPlatform.Application.csproj", "src/Jason.TaskPlatform.Application/"]
RUN dotnet restore "src/Jason.TaskPlatform.HttpApi.Host/Jason.TaskPlatform.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/Jason.TaskPlatform.HttpApi.Host"
RUN dotnet build "Jason.TaskPlatform.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Jason.TaskPlatform.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Jason.TaskPlatform.HttpApi.Host.dll"]