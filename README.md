# Esgard Store

A desktop Point-of-Sale (POS) system developed as a university group project using **C# Windows Forms** and **Microsoft SQL Server**.

The system is designed to support day-to-day store operations, including employee management, purchasing, returns, product type maintenance, client management, and reporting.

## Features

### Employee Management

* Add new employees
* Search for existing employees
* Update employee information
* Delete employees where permitted by database relationships
* View employee records

### Client Management

* Maintain client information
* Search and manage existing clients

### Purchasing

* Process purchases
* Record purchase information
* Associate transactions with employees and other relevant data

### Returns

* Process product returns
* Manage return information

### Product Type Management

* Add and maintain product types
* View existing product type information

### Reports

* View and generate system information and reports

### User Authentication

* Login functionality
* Employee and administrator access

## Technologies Used

* **C#**
* **Windows Forms**
* **Microsoft SQL Server**
* **Visual Studio 2019**
* **ADO.NET / SqlClient**
* **Git & GitHub**

## Database

The application uses a Microsoft SQL Server database named **Esgard**.

The database stores information relating to employees, clients, purchases, returns, product types, and other system data.

> **Note:** The SQL Server connection string is configured for the development environment. When running the project on another computer, the connection string may need to be updated to match the local SQL Server instance.

## Getting Started

### Prerequisites

Before running the project, make sure you have:

* Visual Studio 2019 or a compatible version of Visual Studio
* .NET Framework support required by the project
* Microsoft SQL Server
* The Esgard database and required tables

### Installation

1. Clone the repository:

```bash
git clone https://github.com/Group-36-223/Esgard-system.git
```

2. Open the solution file in Visual Studio.

3. Configure the SQL Server connection string in the project to match your local SQL Server instance.

4. Make sure the **Esgard** database is available on your SQL Server instance.

5. Build the solution.

6. Run the application from Visual Studio.

## Project Structure

```text
Esgard-system/
└── ESGARD STORE/
    └── ESGARD STORE/
        ├── Dashboard.cs
        ├── Login.cs
        ├── Maintain Clients.cs
        ├── Maintain Employees.cs
        ├── MaintainPType.cs
        ├── Purchase Form.cs
        ├── Returns.cs
        ├── Reports.cs
        └── ...
```

## Development

This project was developed collaboratively using Git and GitHub.

Feature development is performed on separate branches before changes are merged into the `main` branch.

## Academic Project

**Esgard Store** was developed as part of a university group software development project.

The project provided practical experience with:

* Desktop application development
* Database integration
* CRUD operations
* SQL Server
* User interfaces
* Version control
* Collaborative software development

## Team

**Group 36**

GitHub Organization:

https://github.com/Group-36-223

## License

This project was developed for academic purposes.
