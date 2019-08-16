
FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base

COPY ./SampleApi/bin/Debug/netcoreapp2.2/publish .

ENTRYPOINT ["dotnet","SampleApi.dll"]
