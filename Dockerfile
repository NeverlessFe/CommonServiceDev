# Use the official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CommonServiceCore/CommonServiceCore.csproj", "CommonServiceCore/"]
RUN dotnet restore "CommonServiceCore/CommonServiceCore.csproj"
COPY . .
WORKDIR "/src/CommonServiceCore"
RUN dotnet build "CommonServiceCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CommonServiceCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CommonServiceCore.dll"]