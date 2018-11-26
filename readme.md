# dotnet-core-mvc

### init

```sh
$ git clone https://github.com/rozeroze/dotnet-core-mvc.git
$ cd dotnet-core-mvc
$ vagrant up
```

if mount error occurred...

```sh
$ sudo yum -y update kernel
$ sudo yum -y install kernel-devel kernel-headers dkms gcc gcc-c++
```

and

```sh
$ vagrant reload
```

### start

```sh
$ vagrant ssh
```

```sh
$ cd ~/src/Training
$ dotnet run
```

open your browser -> http://192.168.55.5:8000


### history

```sh
$ cd ~/src
$ dotnet new mvc -n Training
$ cd Training
$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
$ vim Models/Model.cs
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
$ dotnet tool install -g dotnet-aspnet-codegenerator
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
$ dotnet restore
$ dotnet aspnet-codegenerator controller -name BlogsController -m Blog -dc BloggingContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

> https://docs.microsoft.com/ja-jp/ef/core/get-started/aspnetcore/new-db?tabs=netcore-cli

