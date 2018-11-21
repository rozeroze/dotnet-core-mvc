# dotnet-core-mvc

### mount error

> https://qiita.com/maimai-swap/items/3caf496443773e6859fd

```sh
[vagrant@dotnet]
$ sudo yum -y update kernel
$ sudo yum -y install kernel-devel kernel-headers dkms gcc gcc-c++
```

```sh
[host]
$ vagrant reload
```

### into vagrant

```sh
[vagrant@dotnet]
$ cd ~/src
$ dotnet new mvc -n EFGetStarted.AspNetCore.NewDb
$ cd EFGetStarted.AspNetCore.NewDb
$ dotnet add package Microsoft.EntitiFrameworkCore.Sqlite
$ vim Models/Model.cs
```

> https://docs.microsoft.com/ja-jp/ef/core/get-started/aspnetcore/new-db?tabs=netcore-cli

```sh
[vagrant@dotnet]
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
$ dotnet tool install -g dotnet-aspnet-codegenerator
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
$ dotnet restore
$ dotnet aspnet-codegenerator controller -name BlogsController -m Blog -dc BloggingContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

### run

```sh
[vagrant@dotnet]
$ cd ~/src/EFGetStarted.AspNetCore.NewDb
$ dotnet run
```

browser -> http://192.168.55.5:8000

