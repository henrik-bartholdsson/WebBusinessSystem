#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.2-buster-slim-arm32v7 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
RUN apt-get update
RUN apt-get install -y curl
RUN apt-get install -y libpng-dev libjpeg-dev curl libxi6 build-essential libgl1-mesa-glx
RUN curl -sL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs

WORKDIR /src
COPY ["FrontEnd_ReactJs/FrontEnd_ReactJs.csproj", "FrontEnd_ReactJs/"]
COPY ["WebBS.Core/WebBS.Core.csproj", "WebBS.Core/"]
COPY ["WebBS.Data/WebBS.Data.csproj", "WebBS.Data/"]
RUN dotnet restore "FrontEnd_ReactJs/FrontEnd_ReactJs.csproj"
COPY . .
WORKDIR "/src/FrontEnd_ReactJs"
RUN dotnet build "FrontEnd_ReactJs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FrontEnd_ReactJs.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrontEnd_ReactJs.dll"]