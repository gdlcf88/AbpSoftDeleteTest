FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["AbpSoftDeleteTest/src/SoftDeleteTest.Web/SoftDeleteTest.Web.csproj", "src/AbpSoftDeleteTest.Web/"]
RUN dotnet restore "AbpSoftDeleteTest/src/SoftDeleteTest.Web/SoftDeleteTest.Web.csproj"
COPY . .
WORKDIR "/src/SoftDeleteTest/src/SoftDeleteTest.Web"
RUN dotnet build "SoftDeleteTest.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SoftDeleteTest.Web.csproj" --no-restore -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SoftDeleteTest.Web.dll"]
