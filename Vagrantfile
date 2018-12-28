# -*- mode: ruby -*-
# vi: set ft=ruby ts=2 sts=2 sw=2 et :

Vagrant.configure(2) do |config|

  config.vm.box = "centos/7"
  config.vm.network "private_network", ip: "192.168.55.5"

  config.vm.synced_folder "./src", "/home/vagrant/src"

  config.vm.provider "virtualbox" do |vb|
    vb.memory = 4096
  end

  config.vm.provision "shell", inline: <<-SHELL
    # asp.net core
    rpm -Uvh https://packages.microsoft.com/config/rhel/7/packages-microsoft-prod.rpm
    yum -y install dotnet-sdk-2.1
    # sqlserver
    curl -o /etc/yum.repos.d/mssql-server.repo https://packages.microsoft.com/config/rhel/7/mssql-server-2017.repo
    yum install -y mssql-server
    sudo curl -o /etc/yum.repos.d/msprod.repo https://packages.microsoft.com/config/rhel/7/prod.repo
    sudo yum install -y mssql-tools unixODBC-devel
  SHELL

end
