# EShopCatelog
> Simple Microservice template with MongoDB.  

### Prerequisites
- .NET core sdk 3.1
- docker
    
### Dependencies
- Microsoft.EntityFrameworkCore
- MongoDB.Driver
    
### MongoDB Server
Run MongoDB server in Docker with just two command lines:
```
docker volume create --name=mongodata
docker run --name momgodb_server -v mongodata:/data/db -d -p 27017:27017 mongo
```   
#### Robo 3T
The Robo 3T (formerly Robomongo) is a free tool used to connect and manage your MongoDB.    
[Download Robo 3T from here](https://robomongo.org/).
   
### Docker Desktop
As a developer you need this tool to run containers.   
Download Link: [Docker Desktop](https://www.docker.com/products/docker-desktop). 
    
### Testing
[TODO]
