
FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
ARG NAME="Default"
RUN echo "$NAME"
COPY ./publish .


ENTRYPOINT ["dotnet", "${NAME}.dll"]


