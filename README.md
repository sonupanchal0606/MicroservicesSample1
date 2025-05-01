# 🧩 Simple Microservices Implementation in C# with PostgreSQL

## ✅ Project Overview

This solution demonstrates a basic microservices architecture using C#, .NET 8, and PostgreSQL. It includes:

- **2 Microservices**:
  - `ProductService` – Manages product data
  - `OrderService` – Manages order data
- **API Gateway** using [Ocelot](https://ocelot.readthedocs.io/en/latest/)
- **Database**: Each microservice uses its own PostgreSQL instance

---

## 🧰 Prerequisites

Make sure you have the following installed:

- Visual Studio 2022 or later
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- PostgreSQL (installed locally)
- Required NuGet Packages:
  - `Npgsql.EntityFrameworkCore.PostgreSQL`
  - `Ocelot`

---

## 📁 Project Structure
```
MicroservicesSolution/
│
├── APIGateway/                     # Ocelot API Gateway project
│   ├── APIGateway.csproj
│   ├── Program.cs
│   ├── ocelot.json                 # Ocelot routing configuration
│   └── appsettings.json
│
├── ProductService/                # Product microservice
│   ├── ProductService.csproj
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   ├── Services/ --> not in this project
│   ├── Repositories/ --> not in this project
│   ├── Program.cs
│   └── appsettings.json           # Includes PostgreSQL connection string
│
├── OrderService/                  # Order microservice
│   ├── OrderService.csproj
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   ├── Services/ --> not in this project
│   ├── Repositories/ --> not in this project
│   ├── Program.cs
│   └── appsettings.json           # Includes PostgreSQL connection string
│
├── MicroservicesSolution.sln      # Visual Studio solution file
```
---


![image](https://github.com/user-attachments/assets/eefc3f7e-00ea-4d58-826e-16ee6471a721)
