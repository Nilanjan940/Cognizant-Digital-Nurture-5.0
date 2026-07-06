# 🚀 2_WebApi_Handson

> ✅ Week 3 Assignment – Cognizant Digital Nurture 5.0  
> 📌 Objective: Build a Web API using ASP.NET Core with Swagger UI, custom routing, and test via Postman.  
> 👤 Author: Nilanjan Pradhan 

---

## 📋 Objectives Covered

- ✅ Understand RESTful API, WebAPI, and Microservice concepts
- ✅ Implement GET, POST, PUT, DELETE using action verbs
- ✅ Install and configure Swagger (`Swashbuckle.AspNetCore`)
- ✅ Explore HttpRequest, HttpResponse, and Status Codes
- ✅ Use Postman to test API endpoints
- ✅ Implement clean service-based architecture (`EmployeeService`)
- ✅ Customize routing (e.g., `/api/Emp`)
- ✅ Use configuration files like `launchSettings.json`, `appsettings.json`

---

## 🗂️ Project Structure

2_WebApi_Handson/
├── Controllers/
│ └── EmployeeController.cs # Handles API requests
├── Models/
│ └── Employee.cs # POCO class with properties
├── Services/
│ └── EmployeeService.cs # Handles business logic
├── Properties/
│ └── launchSettings.json # Port, profile info
├── Program.cs # Startup and DI config
├── appsettings.json # App-level settings
└── 2_WebApi_Handson.csproj # Project file


---

## 📁 Example Data

```json
[
  {
    "id": 1,
    "name": "Dhruv Kushwaha",
    "department": "Software",
    "salary": 80000
  },
  {
    "id": 2,
    "name": "Anjali Verma",
    "department": "Testing",
    "salary": 65000
  },
  {
    "id": 3,
    "name": "Rohan Mehta",
    "department": "Support",
    "salary": 55000
  }
]
🔧 How to Run
Open the solution in Visual Studio 2022.

Set 2_WebApi_Handson as Startup Project.

Press F5 or Ctrl+F5.

Browser launches at:
http://localhost:<port>/swagger


🔍 Swagger UI – Testing Interface
Lists all action methods in EmployeeController

Enables Try it out, input JSON, and see live results


🔁 Sample API Endpoints
Verb	URL	Description
GET	/api/Emp	List all employees
POST	/api/Emp	Add a new employee
PUT	/api/Emp/{id}	Update an employee
DELETE	/api/Emp/{id}	Delete an employee

 Postman Testing Guide
✅ Create new collection

✅ Add individual requests with:

URL: http://localhost:<port>/api/Emp

Body: Set raw → JSON

Methods: GET, POST, PUT, DELETE

✅ Observe response body and status code (200 OK, 400 BadRequest)

✅ Output Example in Swagger
[
  "Dhruv Kushwaha",
  "Anjali Verma",
  "Rohan Mehta",
  "string"
]

📄 Configuration Files Used
File	Purpose
Program.cs	Service registration, pipeline setup
launchSettings.json	Port number, environment
appsettings.json	Optional app settings

💡 Concepts Practiced
ASP.NET Core Web API

Swagger Documentation (OpenAPI)

Routing ([Route("api/Emp")])

Action Verbs (HttpGet, HttpPost, etc.)

Status Codes (200 OK, 400 BadRequest)

Postman testing

Service-oriented coding (EmployeeService)