# -*- mode: ruby -*-
# vi: set ft=ruby ts=2 sts=2 sw=2 et :

Vagrant.configure(2) do |config|

  config.vm.box = "centos/7"
  config.vm.network "private_network", ip: "192.168.55.5"

  # yum update すると mount でエラーが出るようになる
  config.vm.synced_folder "./src", "/home/vagrant/src"

  config.vm.provider "virtualbox" do |vb|
      vb.memory = 2048
      vb.linked_clone = true
  end

  config.vm.provision "shell", inline: <<-SHELL
    # asp.net core
    rpm -Uvh https://packages.microsoft.com/config/rhel/7/packages-microsoft-prod.rpm
    yum -y update
    yum -y install dotnet-sdk-2.1
  SHELL

end
