FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["/src/AbpSoftDeleteTest/AbpSoftDeleteTest.Web/AbpSoftDeleteTest.Web.csproj", "/src/AbpSoftDeleteTest/AbpSoftDeleteTest.Web/"]
RUN dotnet restore "/src/AbpSoftDeleteTest/AbpSoftDeleteTest.Web/AbpSoftDeleteTest.Web.csproj"
COPY . .
WORKDIR "/src/AbpSoftDeleteTest/AbpSoftDeleteTest.Web"
RUN dotnet build "AbpSoftDeleteTest.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AbpSoftDeleteTest.Web.csproj" --no-restore -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbpSoftDeleteTest.Web.dll"]
