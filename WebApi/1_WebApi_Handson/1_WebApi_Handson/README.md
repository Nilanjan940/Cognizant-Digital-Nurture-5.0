# Lab 1: Creating a Simple Web API Using ASP.NET Core  

 > ✅ Week 3 Assignment – Cognizant Digital Nurture 5.0  
> 📌 Objective: Creating a Simple Web API Using ASP.NET Core  
> 👤 Author: Nilanjan Pradhan
---

##  Objective

To understand the structure and implementation of a simple RESTful Web API using ASP.NET Core. This lab focuses on core concepts like HTTP methods, response codes, Web API structure, and configuration.

---

##  Topics Covered

###  RESTful Web Services
- Follows **Stateless** communication model
- Uses standard HTTP verbs: `GET`, `POST`, `PUT`, `DELETE`
- Can return data in multiple formats (e.g., JSON, XML)
- Supports **Microservices Architecture** and modern distributed systems

###  Web API vs WebService
| Feature | Web API (.NET Core) | Web Service (.NET 4.5) |
|--------|----------------------|-------------------------|
| Format | JSON, XML, plain text | Mostly XML (SOAP) |
| Platform | Cross-platform | Windows only |
| Lightweight | Yes | No |
| Config | `Startup.cs`, `appsettings.json`, `launchSettings.json` | `Route.config`, `Web.config` |

---

##  Implementation Summary

| Feature | Description |
|--------|-------------|
|  Project Type | ASP.NET Core Web API |
|  Tool Used | Visual Studio + Swagger UI |
|  Controller | `ValuesController.cs` with 4 action methods |
|  Endpoints | `/api/Values` |
|  HTTP Verbs | `GET`, `POST`, `PUT`, `DELETE` |
|  Status Codes | `200 OK`, `400 BadRequest` |

---

##  Controller Actions Overview

| HTTP Verb | Route | Purpose |
|-----------|-------|---------|
| GET | `/api/Values` | Retrieves all string values |
| POST | `/api/Values` | Adds a new string value |
| PUT | `/api/Values/{id}` | Updates an existing string by index |
| DELETE | `/api/Values/{id}` | Deletes a string value by index |

---

##  Configuration Files Used

| File | Purpose |
|------|---------|
| `Program.cs` | Configures services, middleware, routing |
| `appsettings.json` | Stores environment and app settings |
| `launchSettings.json` | Defines port and profile for development environment |
| `Startup.cs` | *Not used in .NET 6+, replaced by Program.cs* |

---

##  Testing

Tested all 4 endpoints using **Swagger UI**:
- ✅ GET returned initial values.
- ✅ POST added values correctly.
- ✅ PUT updated value by index.
- ✅ DELETE removed value by index.
- Response codes returned appropriately.

---

##  Lab Status: **Completed Successfully**
