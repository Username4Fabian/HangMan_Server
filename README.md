# HangMan_Server
HangMan Game using a C# Server

A multiplayer Hangman game where users can play the game through a website. The server is implemented in C# using ASP.NET Core, and the client is a simple web page using HTML, CSS, and JavaScript.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

* [.NET Core SDK](https://dotnet.microsoft.com/download)
* A modern web browser
* A text editor or integrated development environment (IDE)

### Installing

1. Clone this repository
```bash
git clone https://github.com/yourusername/hangman.git
```

2. Go into the repository
```bash
cd hangman
```

3. Restore .NET packages
```bash
dotnet restore
```

### Running the Application

1. Run the server
```bash
dotnet run
```

2. Open a web browser and navigate to `http://localhost:5000` (or `https://localhost:5001` if using HTTPS)

## Project Structure

The server-side code is located in the `Server` directory and the client-side code is located in the `Client` directory.

* `Server/GameController.cs` - This is where the game server logic is located. It uses an in-memory dictionary to store games.
* `Server/GameHub.cs` - This is where the SignalR hub is defined. It allows real-time communication between the server and clients.
* `Client/index.html` - This is the main webpage that players will interact with.
* `Client/styles.css` - This file contains the styles for the webpage.
* `Client/main.js` - This file contains the JavaScript that handles user interaction and communicates with the server.

## Built With

* [.NET Core](https://dotnet.microsoft.com/) - The server framework
* [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr) - Used to provide real-time web functionality
* [HTML/CSS/JavaScript](https://developer.mozilla.org/en-US/docs/Learn) - Used for the client-side interface

## Acknowledgments

* OpenAI's ChatGPT for providing initial guidance on project architecture

Please note that these instructions do not cover how to deploy the application to a production environment. Depending on where and how you want to host the application, you may need to perform additional steps, such as setting up a reverse proxy for the ASP.NET Core server, setting up a database to store game states, and configuring HTTPS.
