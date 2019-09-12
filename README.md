#dotnet cli & entity framework

`dotnet new mvc -n FirstDotnetCoreMVC`
<br/>
`cd FirstDotnetCoreMVC`

_optional (already contains it in Microsoft.AspNetCore.App package)_ 

`dotnet add package Microsoft.EntityFrameworkCore.Sqlite`

after create DbContext & Entities and also each changes, you should apply the flowing code

`dotnet ef migrations add InitialCreate`
<br/>
`dotnet ef database update`
