# JWT Authentication System

## Table of Contents
1. [Introduction](#introduction)
2. [Technologies Used](#technologies-used)
3. [Features](#features)
4. [Setup Instructions](#setup-instructions)
5. [Endpoints](#endpoints)
6. [Usage Example](#usage-example)
7. [License](#license)

---

## Introduction
This project demonstrates how to implement a JWT (JSON Web Token) based authentication system using ASP.NET Core. The project includes features such as user login, token generation, and secured API endpoints.

---

## Technologies Used
- **ASP.NET Core** (Web API)
- **Entity Framework Core**
- **System.IdentityModel.Tokens.Jwt** (for JWT handling)
- **Microsoft.AspNetCore.Authentication.JwtBearer** (for JWT authentication middleware)
- **SQL Server** or **PostgreSQL** (database support)

---

## Features
- User authentication using JWT.
- Secure API endpoints requiring token-based authentication.
- Simple user model with email and password fields.

---

## Setup Instructions

### 1. Clone the Repository
```bash
git clone <repository-url>
cd <repository-folder>
```

### 2. Install Dependencies
Install necessary NuGet packages:
```bash
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer
Install-Package System.IdentityModel.Tokens.Jwt
```

### 3. Configure the Database
Update the `appsettings.json` file with your database connection string:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=JwtAuthDb;Trusted_Connection=True;"
}
```
For PostgreSQL:
```json
"ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=JwtAuthDb;Username=your_username;Password=your_password"
}
```

### 4. Apply Migrations and Update the Database
```bash
Add-Migration InitialCreate
Update-Database
```

### 5. Run the Application
Start the application using Visual Studio or the command line:
```bash
dotnet run
```

---

## Endpoints

### 1. Login Endpoint
**POST** `/api/auth/login`
- **Request Body:**
  ```json
  {
      "email": "test@example.com",
      "password": "password"
  }
  ```
- **Response:**
  ```json
  {
      "token": "<JWT_TOKEN>"
  }
  ```

### 2. Secure Endpoint
**GET** `/api/secure/data`
- Requires a valid JWT token in the `Authorization` header:
  ```
  Authorization: Bearer <JWT_TOKEN>
  ```
- **Response:**
  ```json
  {
      "message": "This is a secured endpoint."
  }
  ```

---

## Usage Example

1. **Authenticate User**
   - Use a tool like Postman or cURL to send a `POST` request to `/api/auth/login` with valid credentials.
   - Retrieve the JWT token from the response.

2. **Access Secure Endpoints**
   - Use the retrieved JWT token in the `Authorization` header to access protected routes.

---

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
