@echo off

dotnet tool restore
dotnet run --project src/Build/Build.fsproj -- %*
