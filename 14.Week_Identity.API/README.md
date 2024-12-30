# User Management API

This is a simple ASP.NET Core Web API project that implements basic user management functionality. The project includes the ability to register users with email and password without using hashing for simplicity (not recommended for production).

---

## 📋 Table of Contents

1. [Introduction](#introduction)
2. [Technologies](#technologies)
3. [Endpoints](#endpoints)
4. [Usage](#usage)
5. [Explanation](#explanation)
6. [Output](#output)
7. [License](#license)

---

## 📖 Introduction

The **User Management API** allows users to register by providing their email and password. This project demonstrates basic API development using ASP.NET Core and Entity Framework. The password is stored as plain text (only for demonstration purposes; not recommended).

---

## 🛠 Technologies

- **Framework**: .NET 6.0
- **Language**: C#
- **Database**: SQL Server (Entity Framework Code First)
- **IDE**: Visual Studio 2022
- **Tools**:
  - Entity Framework Core
  - Postman (for testing)

---

## 📂 Endpoints

### 1. Register User
- **Endpoint**: `POST /api/user/register`
- **Request Body**:
  ```json
  {
      "email": "user@example.com",
      "password": "securepassword"
  }
  ```
- **Response**:
  ```json
  {
      "message": "Kullanıcı başarıyla kaydedildi."
  }
  ```

---

## 🔧 Usage

### Steps to Run the Project
1. Clone the repository.
2. Open the project in Visual Studio.
3. Update the `appsettings.json` file with your SQL Server credentials:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=UserDb;User Id=yourusername;Password=yourpassword;"
   }
   ```
4. Open the **Package Manager Console** and run the following commands:
   - Add a migration: `Add-Migration InitialCreate`
   - Update the database: `Update-Database`
5. Run the project (default URL: `https://localhost:5001`).
6. Test the endpoints using Postman or Swagger UI.

---

## 📝 Explanation

- **Models/User.cs**: Defines the `User` model with `Email` and `Password` fields and basic validation using Data Annotations.
- **Data/AppDbContext.cs**: Configures the database context and defines the `Users` table.
- **Controllers/UserController.cs**: Contains the `Register` endpoint for creating new users.
- **appsettings.json**: Contains the database connection string.

---

## 📊 Output

When a user is successfully registered, the API returns the following response:

**Response**:
```json
{
    "message": "Kullanıcı başarıyla kaydedildi."
}
```

---

## 📜 License

This project is licensed under the MIT License. Feel free to use and modify the code as needed.
