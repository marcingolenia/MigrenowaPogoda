FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /app
# BUILD
COPY src/*/*.fsproj ./
RUN for file in $(ls *.fsproj); do mkdir -p src/${file%.*}/ && mv $file src/${file%.*}/; done
COPY tests/*/*.fsproj ./
RUN for file in $(ls *.fsproj); do mkdir -p tests/${file%.*}/ && mv $file tests/${file%.*}/; done
COPY *.sln ./
RUN dotnet restore
COPY ./ ./
RUN dotnet publish -c Release -o bin
# RUNTIME
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine
WORKDIR /app
COPY --from=build /app/bin .
EXPOSE 8080
ENTRYPOINT ["dotnet", "Api.dll", "--urls", "http://0.0.0.0:8080"]