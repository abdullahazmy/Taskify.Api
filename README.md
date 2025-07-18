# Taskify

## 📦 Technologies
- .NET 8 Web API
- Identity + JWT + Google Auth
- PostgreSQL
- Entity Framework Core (Code First)
- SignalR (Real-time)
- Docker

## 🧱 Data Model Overview

### 🧑 Users
- Identity-based
- Can be in multiple projects via UserProject
- Stores Refresh Tokens

### 📁 Projects
- Hold multiple Tasks
- Have many Users via UserProject

### 🗂 Tasks
- Belong to one Project
- Assigned to a User
- Have comments, status, priority

### 💬 Comments
- Linked to both Task and Author

## 🔐 Auth Flow
- JWT Bearer Token
- Google OAuth Login
- Refresh Tokens for session rotation

...

## 🛠 Setup
- `dotnet ef database update`
- Run via `dotnet run`

...

