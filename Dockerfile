FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 6951
EXPOSE 44305
VOLUME /Config

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY src/TorrentBox.Api/TorrentBox.Api.csproj src/TorrentBox.Api/
COPY src/TorrentBox.TransmissionClient/TorrentBox.TransmissionClient.csproj src/TorrentBox.TransmissionClient/
RUN dotnet restore src/TorrentBox.Api/TorrentBox.Api.csproj
COPY . .
WORKDIR /src/src/TorrentBox.Api
RUN dotnet build TorrentBox.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TorrentBox.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TorrentBox.Api.dll"]
