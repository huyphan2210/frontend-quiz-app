# Frontend Quiz App

A full-stack web application built with:
- **Frontend**: TypeScript, React, Vite
- **Backend**: C# with .NET Core 8
- **Database**: PostgreSQL using Entity Framework Core

## Live Url: [Click here](https://frontend-quiz-app-neon-alpha.vercel.app/)

## Prerequisites

Ensure you have the following installed:

- **Node.js** (Latest LTS version) – [Download](https://nodejs.org/)
- **Yarn** (or npm) – [Download](https://yarnpkg.com/)
- **.NET 8 SDK** – [Download](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- **PostgreSQL** (Latest stable version) – [Download](https://www.postgresql.org/download/)

---

## Setup Instructions

### 1. Clone the Repository
```sh
git clone https://github.com/huyphan2210/frontend-quiz-app.git
cd frontend-quiz-app
```

---

## Frontend Setup (React + Vite)

### Install Dependencies
```sh
cd frontend-quiz-app.client
yarn install  # or npm install
```

### Start the Frontend
```sh
yarn dev  # or npm run dev
```
The app should now be running at `http://localhost:5173/`.

---

## Backend Setup (.NET Core 8 + EF Core)

### Install Dependencies
```sh
cd frontend-quiz-app.Server
dotnet restore
```

### Configure Environment Variables
Config a **`appsettings.json`** file in the `frontend-quiz-app.Server` folder:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=quizdb;Username=yourusername;Password=yourpassword"
  },
}
```

### Start the Backend
#### Recommendation: Use Visual Studio to run the Backend
```sh
dotnet run
```
The server should be running at `http://localhost:7278/`.

---

### Database Connection Issues
- Ensure PostgreSQL is running:
  ```sh
  sudo service postgresql start  # Linux/Mac
  net start postgresql           # Windows
  ```
- Verify credentials in `appsettings.json`.
- Run `dotnet ef database update` again if migrations were not applied.

---

## Deployment

- **Frontend**: Deploy on Vercel/Netlify.
- **Backend**: Deploy on Heroku/Azure/GCP.
- **Database**: Use a managed PostgreSQL service.