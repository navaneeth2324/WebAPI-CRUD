# WebAPI-CRUD

This project is a CRUD (Create, Read, Update, Delete) Web API built with .NET 8. It includes user authentication using JWT tokens and basic logging.

## Features

- User registration and login with JWT authentication
- CRUD operations for managing users and products
- Entity Framework Core for database interactions
- Swagger for API documentation
- Logging with Microsoft.Extensions.Logging

## Prerequisites

- .NET 8 SDK
- SQL Server

## Getting Started

### Configuration

1. **Clone the repository**: git clone https://github.com/your-repo/WebAPI-CRUD.git 
2. **Update the database connection string**:
   Modify the `appsettings.json` file to include your SQL Server connection string.
```
{ 
	"ConnectionStrings": { "DefaultConnection": "Server=YOUR_SERVER;Database=CrudApiDb;Trusted_Connection=True;TrustServerCertificate=True" }, "Jwt": { "Key": "your_secret_key", "Issuer": "your_issuer", "Audience": "your_audience" },
	"Logging": { "LogLevel": { "Default": "Information", "Microsoft.AspNetCore": "Warning" } },
	"AllowedHosts": "*" 
}
```
 
3. **Apply Migrations**:
   Run the following commands to apply migrations and create the database.
 ```
  dotnet ef migrations add InitialCreate dotnet ef database update
 ```

### Running the Application

1. **Build and run the application**:
```
dotnet run
```
2. **Access the API**:
   Open your browser and navigate to `https://localhost:5001/swagger` to view the Swagger UI and explore the API endpoints.

## API Endpoints

### Authentication

- **Register**: `POST /api/auth/register`
- **Login**: `POST /api/auth/login`

### Products

- **Get All Products**: `GET /api/products`
- **Get Product by ID**: `GET /api/products/{id}`
- **Create Product**: `POST /api/products`
- **Update Product**: `PUT /api/products/{id}`
- **Delete Product**: `DELETE /api/products/{id}`


