# dotnet cli & entity framework 

`dotnet new mvc -n FirstDotnetCoreMVC`

`cd FirstDotnetCoreMVC`

_optional (already contains it in Microsoft.AspNetCore.App package)_ 

`dotnet add package Microsoft.EntityFrameworkCore.Sqlite`

after create DbContext & Entities and also each changes, you should apply the flowing code

`dotnet ef migrations add InitialCreate`

`dotnet ef database update`

if you use ConnectionString in EnvironmentVariables. 
before execute database update, you should apply the flowing code

`$Env:ASPNETCORE_DB_PATH = "---"`

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

## deploy 
### heroku
install the heroku cli and then apply `heroku login` command in the project folder in your local machine

_if you have a heroku application_  
`heroku git:remote -a akb-first-dotnet-core-mvc`
_<br> or <br>_ 
`heroku create akb-first-dotnet-core-mvc`

just one time apply flow command for each application  
`heroku buildpacks:set jincod/dotnetcore`

for the deploy to this application just apply flowing command  
`git push heroku master`


### CI/CD

`heroku auth:token` get token for using in CI machine  
`$Env:HEROKU_API_KEY = "token"`

## scaffold

`dotnet tool install -g dotnet-aspnet-codegenerator`   

`dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`  
 
`dotnet restore`   

`dotnet aspnet-codegenerator controller -name EmployeeController -m Employee -dc EmployeeDbContext --rel
ativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries`





