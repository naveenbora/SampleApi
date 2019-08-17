
FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base

COPY ./bin/Debug/netcoreapp2.2/publish .

<<<<<<< HEAD
ENTRYPOINT ["dotnet", "SampleApi.dll"]


=======
ENTRYPOINT ["dotnet","SampleApi.dll"]
>>>>>>> 978272e5674c4a12f53833c36446cc5c0b861bbb
