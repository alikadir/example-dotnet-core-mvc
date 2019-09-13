# dotnet cli & entity framework 

`dotnet new mvc -n FirstDotnetCoreMVC`

`cd FirstDotnetCoreMVC`

_optional (already contains it in Microsoft.AspNetCore.App package)_ 

`dotnet add package Microsoft.EntityFrameworkCore.Sqlite`

after create DbContext & Entities and also each changes, you should apply the flowing code

`dotnet ef migrations add InitialCreate`

`dotnet ef database update`

## run & build

`dotnet build`

_if you want to build to be release_

`dotnet build --configuration Release`

_if you use external nuget source_

`dotnet build --source c:\packages\mypackages`

_if you are in project folder_

`dotnet run`

_if you have a compiled project (attention! don't use run command)_ 

`dotnet myapp.dll`

