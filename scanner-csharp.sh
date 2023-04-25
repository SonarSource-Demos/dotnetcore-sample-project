#!/bin/bash

dotnet restore
dotnet sonarscanner begin /k:"csharp-dotnetcore-sonar" /n:"csharp-dotnetcore-sonar" /d:sonar.verbose=true /d:sonar.login="input your token here"
dotnet build 
dotnet sonarscanner end /d:sonar.login="input your token here"
