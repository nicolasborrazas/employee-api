
---

# Employee API (In dev)

This repository contains the source code for an Employee API built using ASP.NET Core. The API provides an endpoint to retrieve employee data, with the employee's name and job role returned in JSON format.
Test URL http://localhost:5025/api/employee

## Getting Started

### Prerequisites

To run this project, we needed the following software installed:

- [.NET SDK](https://dotnet.microsoft.com/download) - to build and run the ASP.NET Core application.
- [Visual Studio Code](https://code.visualstudio.com/) - for code editing.

### Installation

1. Clone this repository to your local machine using the following command:

   ```bash
   git clone https://github.com/your-username/employee-api.git
   ```

2. Navigate to the project directory:

   ```bash
   cd employee-api
   ```

### Running the Application

To run the application, execute the following command in the terminal:

```bash
dotnet run
```

This will start the application, and it will be accessible at `http://localhost:5025`.

## API Endpoint

The API provides a single endpoint to retrieve employee data:

- **GET** `/api/employee`: Returns the data of a hardcoded employee in JSON format.

Example response:

```json
{
    "nombre": "Nicolas Borrazas",
    "jobRole": "IT Helpdesk"
}
```

## Project Structure

- **EmployeeController.cs**: This file contains the controller for the employee endpoint. It handles incoming HTTP requests and returns the employee data.
- **Program.cs**: This file contains the entry point for the application. It sets up and starts the web server.
- **Startup.cs**: This file contains the application's startup logic. It configures services and middleware.
- **appsettings.json** and **appsettings.Development.json**: These files contain configuration settings for the application.
- **EmployeeApi.csproj**: This file is the project file for the ASP.NET Core application.
- **EmployeeApi.sln**: This file is the solution file for the project, used to organize multiple projects.



