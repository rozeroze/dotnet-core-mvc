# dotnet-core-mvc

### init

```sh
$ git clone https://github.com/rozeroze/dotnet-core-mvc.git
$ cd dotnet-core-mvc
$ vagrant up
```

if vagrant-box 'centos/7' is not found...

```sh
$ vagrant box add centos/7
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
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
$ dotnet run
```

open your browser -> http://192.168.55.5:8000


### history

##### Initial

```sh
$ cd ~/src
$ dotnet new mvc -n Training
$ cd Training
$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
$ vi Models/Model.cs
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
$ dotnet tool install -g dotnet-aspnet-codegenerator
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
$ dotnet restore
$ dotnet aspnet-codegenerator controller -name BlogsController -m Blog -dc BloggingContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

> https://docs.microsoft.com/ja-jp/ef/core/get-started/aspnetcore/new-db?tabs=netcore-cli

##### Add Identity

```sh
$ dotnet new mvc --auth Individual -n Training
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.1.6
$ dotnet restore
```

> https://docs.microsoft.com/ja-jp/aspnet/core/security/authentication/identity?view=aspnetcore-2.2&tabs=netcore-cli

##### Remove 'yum update' & 'dotnet packages'

```sh
$ vagrant box update
```

'centos/7' updated to '1811.02' (2018-12-21)

```sh
$ vagrant up
$ vagrant ssh
$ cd ~/src
$ sh init.sh
```
