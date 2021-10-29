# Parks and API

### By Anna Clarke

An API that allows developers to access United States parks information.

## Technologies Used
* C#
* ASP.NET Core MVC
* Entity Framework Core
* Swagger
* MySql

## Setup and Usage

### Installation Requirements
* text editor, such as VS Code
* .NET 5

### Setup
* Clone this repository to your desktop
* Open top directory in your text editor
* Create appsettings.json file in ParksandAPI.Solution/ParksandAPI/
* Copy this code into appsettings.json file, replacing YOUR_PASSWORD with your MySql password:  
```{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_and_api;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* In your terminal, navigate into ParksandAPI.Solution/ParksandAPI/ and enter the command `$ dotnet restore` to install necessary packages
* Enter `$ dotnet build` in terminal, to build the program
* Enter `$ dotnet ef database update` in terminal, to build your database
* Enter `$ dotnet run` in terminal, to access API in browser, Postman, or through Swagger

## API Documentation

### Using Swagger Documentation

After completing all setup instructions, use Swagger in your browser to easily view endpoints and manipulate the database. Go to the following URL `http://localhost:5000/swagger` to explore the api with Swagger.

### Endpoints

Base URL: http://localhost:5000

#### HTTP Request

GET /api/parks
POST /api/parks
GET /api/parks/{id}
PUT /api/parks/{id}
DELETE /api/parks/{id}

#### Path Parameters

