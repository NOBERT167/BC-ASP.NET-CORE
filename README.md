# Instructor Management API

An ASP.NET Core Web API for managing instructor data, connected to Microsoft Dynamics 365 Business Central. This API allows you to create, read, update, and delete instructor records in Business Central, leveraging SOAP services.

## Features

- **Add Instructor**: Create a new instructor record in Business Central.
- **Get All Instructors**: Retrieve all instructor records.
- **Get Instructor by ID**: Retrieve details for a specific instructor.
- **Update Instructor**: Modify instructor details.
- **Delete Instructor**: Remove an instructor record from the system.

## Prerequisites

- **.NET 6.0 or later**: [Download here](https://dotnet.microsoft.com/download)
- **Business Central**: Set up with a published SOAP web service for instructor data management.
- **NuGet Packages**:
  - `Newtonsoft.Json`: For JSON serialization
  - `Microsoft.AspNetCore.Mvc`

## Getting Started

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/instructor-management-api.git
    cd instructor-management-api
    ```

2. **Configure Business Central SOAP Service**:
   - Add the SOAP service URL for Business Central in `Models/Credentials.cs`:
     ```
     var endpointAddress = new EndpointAddress("your soap url");
     ```
   - Ensure you’ve set up the service with necessary permissions.

3. **Add Service Reference**:
   - In Visual Studio, right-click the project > **Add > Connected Service**.
   - Choose **Microsoft WCF Web Service Reference Provider**, and add your SOAP service URL.

4. **Configure Authentication**:
   - This project uses Windows authentication to connect to Business Central. Update authentication settings in `appsettings.json` or within your Business Central configuration.

5. **Install Dependencies**:
    ```bash
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.9.0" /> 
    <PackageReference Include="System.ServiceModel.Duplex" Version="6.0.*" />
    <PackageReference Include="System.ServiceModel.Federation" Version="6.0.*" />
    <PackageReference Include="System.ServiceModel.Http" Version="6.0.*" />
    <PackageReference Include="System.ServiceModel.NetTcp" Version="6.0.*" />
    <PackageReference Include="System.ServiceModel.Security" Version="6.0.*" />
    ```

6. **Run the Project**:
    ```bash
    dotnet run
    ```

## API Endpoints

The API exposes the following endpoints:

| Method | Endpoint                    | Description                     |
|--------|------------------------------|---------------------------------|
| POST   | `/api/instructor/add`        | Add a new instructor            |
| GET    | `/api/instructor/{id}`       | Get an instructor by ID         |
| GET    | `/api/instructor`            | Get all instructors             |
| PUT    | `/api/instructor`            | Update an existing instructor   |
| DELETE | `/api/instructor/{id}`       | Delete an instructor by ID      |

### Sample Requests

1. **Add Instructor**:
   ```json
   POST /api/instructor/add
   Content-Type: application/json

   {
     "Instructor_Name": "John Doe",
     "Instructor_ID": "12345",
     "Instructor_Email": "john.doe@example.com",
     "Instructor_Phone_Number": "+1234567890",
     "Instructor_Rate": 100
   }
