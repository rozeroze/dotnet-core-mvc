cd ~/src/Training
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 2.1.0
dotnet tool install -g dotnet-aspnet-codegenerator --version 2.1.5
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.1.5
dotnet restore
