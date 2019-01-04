# dotnet-core-mvc

README, and instead for LOG

### init

1. at first, you must prepare files.
and go to directory

```sh
$ git clone https://github.com/rozeroze/dotnet-core-mvc.git
$ cd dotnet-core-mvc
```

2. `vagrant up`
 * if vagrant-box 'centos/7' is not founded, retry it after `vagrant box add`

```sh
$ vagrant box add centos/7
$ vagrant up
```

if mount error occurred

```sh
$ vagrant plugin install vagrant-vbguest
$ vagrant reload
```

nevertheless mount error occurred,
`vagrant ssh` (into vagrant) and do it(following)

```sh
$ sudo yum -y update kernel
$ sudo yum -y install kernel-devel kernel-headers dkms gcc gcc-c++
```

`logout` (out of vagrant) and `vagrant reload`

### start

if vagrant is not created, or aborted

```sh
$ vagrant up
```

into vagrant

```sh
$ vagrant ssh
```

##### install dotnet packages and tools

```sh
$ cd ~/src
$ sh dotnet-package.sh
```
##### sqlserver install, and it's tool

```sh
$ cd ~/src
$ sudo /opt/mssql/bin/mssql-conf setup
$ sh mssql-tool.sh
$ source ~/.bashrc
```

> sqlserver-setup
> * sqlserver-edition: `2.Developer`
> * administrator-password: `1cHzv6*p`

you can choice other edition and other password.
at that time, you have a thing whose must do

* other-edition choice
  * license authorization
* other-password registered
  * you must change `Training/appsettings.json`
  * L4: __ConnectionStrings.TrainingContext.Password__ to your-password

##### database migration

if sqlserver is inactive, activate it

```sh
$ # check status
$ systemctl status mssql-server
$ # if inactive
$ sudo systemctl start mssql-server
```

create database in sqlserver

```sh
$ sqlcmd -U SA -P 1cHzv6*p -i create-table.sql
```

migration

```sh
$ cd ~/src/Training
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```

##### run the project

```sh
$ cd ~/src/Training
$ dotnet run
```

open your browser -> http://192.168.55.5:8000

### history (instead for log)

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

##### Install SQL-Server

```sh
$ sudo curl -o /etc/yum.repos.d/mssql-server.repo https://packages.microsoft.com/config/rhel/7/mssql-server-2017.repo
$ sudo yum install -y mssql-server
$ sudo /opt/mssql/bin/mssql-conf setup
```

- 2) Developer

ERROR: the installing sqlserver is neseccary least 2000 megabytes.

edit Vagrantfile 'vb.memory = 2048' -> '4096'

```sh
$ vagrant halt
$ vagrant up
```

and after vagrant halt & up, retry it

```sh
$ sudo curl -o /etc/yum.repos.d/msprod.repo https://packages.microsoft.com/config/rhel/7/prod.repo
$ sudo yum install -y mssql-tools unixODBC-devel
$ echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bash_profile
$ echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bashrc
$ source ~/.bashrc
```
