FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["NAD_IABRS/NAD_IABRS.csproj", "NAD_IABRS/"]
RUN dotnet restore "NAD_IABRS/NAD_IABRS.csproj"
COPY . .
WORKDIR "/src/NAD_IABRS"
RUN dotnet build "NAD_IABRS.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "NAD_IABRS.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NAD_IABRS.dll"]