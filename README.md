# Laser Tag Management System

A clean-architecture .NET project for managing laser tag matches, teams, player profiles, and scheduling.

## Tech Stack
- .NET 8
- EF Core 8 (PostgreSQL)
- Clean Architecture (Domain • Application • Infrastructure • API)

## Features
- Team and player registration
- Matchmaking for solo players and full teams
- Match scheduling and results tracking
- Player stats and history

## Project Structure
```

src/
LaserTagManagementSystem.API
LaserTagManagementSystem.Application
LaserTagManagementSystem.Domain
LaserTagManagementSystem.Infrastructure
tests/

```

## Run the App
```

dotnet restore
dotnet build
dotnet run --project src/LaserTagManagementSystem.API

```

## Docker
Build an image:
```

docker build -t lasertag .

```

Run a container:
```

docker run -p 8080:8080 lasertag

```

