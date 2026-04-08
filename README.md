# 🎬 Letterboxd Movie Selector

## Purpose

The purpose of this project is to provide a easier solution to finding a movie to watch from your letterboxd watchlist.

Have you ever wanted to watch a film but couldn't decide on a single one to watch becuase of the endless plethora of amazing films out there? Yeah didn't think so lol. 
However, if you wanted to pretend like you can relate I have the perfect solution for you. The LetterboxdMovieSelector!!!!

This website application was developed by an avid letterboxd user, for the letterboxd users. Follow me on letterboxd? 

[My Letterboxd Profile 😎](https://letterboxd.com/Fortnutmastr006/) 

---

## About

A web application that takes your exported Letterboxd watchlist CSV and randomly selects a movie for you to watch. Built as a migration of an original C# console application into a modern, non-monolithic web architecture using ASP.NET Core and Blazor Server.

---

## Architecture

This solution follows a **separated frontend/backend architecture** across three projects:

```
LetterboxdMovieSelector/
├── MovieSelector.API/        # ASP.NET Core Web API (backend)
├── MovieSelector.Web/        # Blazor Server (frontend)
└── MovieSelector.Shared/     # Shared class library (DTOs/models)
```

- **MovieSelector.API** — handles CSV parsing and random movie selection, exposes REST endpoints
- **MovieSelector.Web** — Blazor Server frontend, communicates with the API via HttpClient
- **MovieSelector.Shared** — contains shared models (e.g. `Movie`) used by both projects

---

## Tech Stack

| Layer | Technology |
|---|---|
| Frontend | Blazor Server (.NET 10) |
| Backend | ASP.NET Core Web API (.NET 10) |
| Shared | .NET Class Library |
| Styling | Bootstrap 5 |
| Language | C# |

---

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (or any IDE with .NET support)
- A Letterboxd account with an exported watchlist CSV

### Exporting your Letterboxd watchlist

1. Log in to [Letterboxd](https://letterboxd.com)
2. Go to **Settings → Import & Export**
3. Click **Export your data**
4. Extract the zip and locate `watchlist.csv`

### Running the app

1. Clone the repository:
```bash
git clone https://github.com/mihirjagdaw/LetterboxdMovieSelector.git
cd LetterboxdMovieSelector
```

2. Start the API:
```bash
cd MovieSelector.API
dotnet run
```

3. In a separate terminal, start the Blazor frontend:
```bash
cd MovieSelector.Web
dotnet run
```

4. Open your browser and navigate to `http://localhost:5235` (or whichever port the Web project runs on)

### Usage

1. On the home page, upload your Letterboxd `watchlist.csv` file
2. The app will randomly select a movie from your watchlist
3. Click **Pick another** to get a different random selection

---

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| POST | `/api/movie/upload` | Upload a Letterboxd watchlist CSV |
| GET | `/api/movie/random` | Get a randomly selected movie |

---

## Project History

This project started as a simple C# console application where users had to manually paste a local file path to their downloaded CSV. It has since been rebuilt as a full web application, solving the original UX problem by allowing CSV uploads directly through the browser.

Original console app: [LetterboxdWatchlistRandomMovieSelector](https://github.com/mihirjagdaw/LetterboxdWatchlistRandomMovieSelector)

---

## Author

**Mihir Jagdaw**  
[GitHub](https://github.com/mihirjagdaw)
