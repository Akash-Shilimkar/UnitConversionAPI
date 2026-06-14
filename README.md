# UnitConversionAPI Task
## Project Structure
UnitConversionAPI
│
├── Controllers
│   └── ConversionController.cs
│
├── Models
│   ├── ConversionRequest.cs
│   └── ConversionResponse.cs
│
├── Services
│   ├── IConversionService.cs
│   └── ConversionService.cs
│
├── Program.cs
└── README.md


## Brief Description of the Solution

This project is an ASP.NET Core Web API that converts numerical values between different units of measurement. The API currently supports conversions for:

- Length (Meter ↔ Foot)
- Weight (Kilogram ↔ Pound)
- Temperature (Celsius ↔ Fahrenheit)

The solution follows a layered structure with Controllers, Services, and Models to keep the code maintainable and easy to extend.

## Instructions to Run the Project Locally

### Prerequisites

- Visual Studio 2022
- .NET 8 SDK

### Steps

1. Clone or download the repository.

2. Open the solution in Visual Studio 2022.

3. Build the solution:

   Build > Build Solution

4. Run the application:

   F5

5. Swagger UI will open automatically in the browser.

   Example:

   https://localhost:7000/swagger


6. Test the API using the Swagger interface.

### Sample Request

json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "foot",
  "value": 10
}

### Sample Response

json
{
  "originalValue": 10,
  "fromUnit": "meter",
  "toUnit": "foot",
  "convertedValue": 32.8084
}

### Design Decisions

- ASP.NET Core Web API was chosen because it provides a lightweight and scalable framework for building RESTful services.
- Business logic is separated into a Service layer to improve maintainability and support future enhancements.
- Dependency Injection is used to follow modern ASP.NET Core development practices.
- Swagger/OpenAPI is enabled for easy API testing and documentation.

### Trade-offs

- Conversion factors are hardcoded as specified in the assignment requirements. In a production environment, these values would typically be stored in a database or configuration source.
- The current implementation supports a limited set of units for simplicity. The architecture can be extended to support additional units and conversion categories in the future.
- Input validation and advanced error handling are kept minimal to focus on the core conversion functionality.
