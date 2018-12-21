cd ~/src/Training
#dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 2.1.0
#dotnet remove package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 2.1.1
dotnet tool install -g dotnet-aspnet-codegenerator --version 2.1.6
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.1.6
dotnet restore
