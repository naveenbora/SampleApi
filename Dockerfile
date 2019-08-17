
FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base


COPY ./publish .

ARG NAME="Default"

ENTRYPOINT ["dotnet", "${NAME}.dll"]


