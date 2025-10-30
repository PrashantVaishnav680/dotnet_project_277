# 🎟️ Event Registration System (ASP.NET Core MVC + SQLite)

The **Event Registration System** is a lightweight, user-friendly web application built using **ASP.NET Core MVC** and **Entity Framework Core** with **SQLite** as the database.  
It allows users to register for events, view all registrations, and manage event attendee data efficiently through a clean and responsive web interface.  

This project demonstrates key **CRUD (Create, Read, Update, Delete)** operations, **MVC architecture**, and **database integration** using SQLite, making it perfect for beginners learning .NET development.

---

## 🧩 Project Overview

The **Event Registration System** is designed to simplify the process of managing event attendees by allowing admins to:

- Add and manage event registrations  
- View all registered participants  
- Edit or delete existing registrations  
- Store all data securely in a local SQLite database  

It follows the **Model-View-Controller (MVC)** design pattern and uses **Entity Framework Core ORM** for database operations.

---

## 🧱 Tech Stack

| Component | Technology Used |
|------------|----------------|
| **Framework** | ASP.NET Core MVC (.NET 8.0) |
| **Language** | C# |
| **Database** | SQLite |
| **ORM** | Entity Framework Core |
| **Frontend** | Bootstrap 5, Razor Views |
| **IDE** | Visual Studio / Visual Studio Code |
| **Version Control** | Git & GitHub |

---

## ⚙️ Installation & Setup Guide

Follow these steps to run the project locally:

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/PrashantVaishnav680/dotnet_project_277.git
cd dotnet_project_277
```

### 2️⃣ Restore Dependencies
```bash
dotnet restore
```
### 3️⃣ Apply Database Migrations
```bash
dotnet ef database update
```

💡 Ensure that you have Microsoft.EntityFrameworkCore.Tools installed. The project uses SQLite, so no external database setup is required.

### 4️⃣ Run the Application
```bash
dotnet run
```

### 5️⃣ View in Browser

Once the server starts, open your browser and visit:

https://localhost:5001


or

http://localhost:5000

## 🧑‍💻 Core Features

| Feature | Description |
|----------|--------------|
| 📝 **Event Registration Management** | Add, edit, delete, and view event registrations. |
| 🔍 **Search Functionality** | Quickly find participants using name or email. |
| 💾 **Database Integration (SQLite)** | All data is stored locally in `eventreg.db` using Entity Framework Core. |
| ⚙️ **Entity Framework Core Support** | Smooth ORM mapping and easy CRUD database operations. |
| 🧱 **Clean MVC Architecture** | Follows Model-View-Controller pattern for scalability and maintainability. |
| 🌐 **Responsive UI** | Built with Bootstrap 5 for a modern, mobile-friendly design. |
| 🚀 **Lightweight Setup** | Runs locally with minimal configuration — no external dependencies required. |

---

## 🗂️ Database Design

### **Tables**
- `EventRegistrations`

### **Schema Example**

| Column Name | Type | Description |
|--------------|------|-------------|
| `Id` | Integer (Primary Key) | Auto-generated ID |
| `Name` | Text | Participant name |
| `Email` | Text | Participant email |
| `Phone` | Text | Contact number |
| `EventName` | Text | Registered event title |

💾 Database Information

All registration data is stored locally in a SQLite file named:

`eventreg.db`

