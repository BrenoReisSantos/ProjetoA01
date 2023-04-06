ARG PROJECT_NAME=Manutemovel
ARG CONFIGURATION=Development

FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build

ARG PROJECT_NAME
ARG CONFIGURATION

COPY ./src ./build
WORKDIR /build/src/${PROJECT_NAME}

RUN dotnet restore
RUN dotnet publish \
    --configuration ${CONFIGURATION} \
    --output /app \
    --self-contained --use-current-runtime

FROM mcr.microsoft.com/dotnet/runtime-deps:7.0-alpine3.17 as runtime

ARG PROJECT_NAME
ENV EXECUTABLE_NAME=${PROJECT_NAME}

WORKDIR /app

COPY --from=build /app ./

ENTRYPOINT ./${PROJECT_NAME}