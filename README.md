# DevJr.CrudClient


Link Hospedado:
* http://34.122.79.117:5000/


# Requisitos
* instalar o docker
* instalar o docker-compose

# Rodar o App

* Fazer clone no projeto 
`git clone https://github.com/asssis/DevJr.CrudClient.git` 
* Iniciar com docker-compose
`docker-compose up`
* Rodar as migrations
`dotnet tool install --global dotnet-ef --version 3.1`
`dotnet ef database update --project /app/DevJr.CrudClient.Infra.Database`


Fazer prototipo

![prototipo](https://user-images.githubusercontent.com/13799390/227415602-3a1e406a-2886-4a79-b25a-e980a51c4ea0.png)
