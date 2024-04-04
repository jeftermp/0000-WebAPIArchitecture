# 0000-WebAPIArchitecture
API that was created to demonstrate a full data cycle and good practices for development

## Features

- GET operations (at first) for managing books
- API endpoints for creating, reading, updating, and deleting books
- Integration with Entity Framework Core for data persistence
- Implementation of dependency injection for services
- Unit testing of controllers and services (Develop stage)
- API documentation with Swagger

  ## Technologies Used

- .NET 8.0
- Entity Framework Core
- xUnit for unit testing
- Swagger for API documentation
- Docker for windows
- SQLServer dor DataBase

  
1. Clone the repository:
- git clone https://github.com/yourusername/dotnet-book-api.git

2. Set up the database connection in appsettings.json:
{
  "ConnectionStrings": {
    "BookContext": "YourDatabaseConnectionString"
  }
}
