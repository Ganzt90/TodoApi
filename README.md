# TodoApi 

Default .Net 7 WebApi Template

### Create Project

```
dotnet new webapi --no-https -o TodoApi
```
Because the project is for educational and learning purposes only, I disabled https by default, for ease of configuration in Windows.


### Add entity Framework

```
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 7.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design -v 7.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 7.0.0
```

### Add tool aspnet-codegenerator

```
dotnet tool uninstall -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator
```

### Scaffold

```
dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoItem -dc TodoContext -outDir Controllers
```

### To run the project in development mode

```
dotnet run --environment Development
```

### To access the Swagger UI

```
https://localhost:<port>/swagger/index.html
```
