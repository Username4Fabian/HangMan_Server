# HangMan_Server

HangMan_Server is a multiplayer Hangman game powered by a C# server using ASP.NET Core. The game's interface is a web page developed with HTML, CSS, and JavaScript. This design leverages modern web technologies for real-time multiplayer interaction while maintaining a separation of concerns between the server-side and client-side logic.

## Project Setup

### Requirements

  * .NET Core SDK
  * A modern web browser
  * A text editor or integrated development environment (IDE)

### Installation and Execution

To clone and run the project locally:

```bash
# Clone the repository
git clone https://github.com/yourusername/hangman.git

# Navigate to the repository
cd hangman

# Restore .NET packages
dotnet restore

# Run the server
dotnet run
```

After running the server, open a web browser and navigate to `http://localhost:5000` (or `https://localhost:5001` for HTTPS).

## Project Architecture

The project follows a client-server architecture with a clear distinction between the server-side and client-side code. The server-side code resides in the `Server` directory, and the client-side code is located in the `Client` directory.

### Server

- `Server/GameController.cs`: This component embodies the game server logic, handling game states with an in-memory dictionary.
- `Server/GameHub.cs`: This component is the SignalR hub definition, facilitating real-time bi-directional communication between the server and clients.

### Client

- `Client/index.html`: The main webpage that serves as the user interface for players.
- `Client/styles.css`: The stylesheet defining the visual aesthetic of the webpage.
- `Client/main.js`: The JavaScript file managing user interaction and server communication.

## Technology Stack

- .NET Core: The server-side framework providing a robust environment for back-end development.
- SignalR: Middleware for real-time web functionality, handling the communication between the server and clients.
- HTML/CSS/JavaScript: The trio responsible for crafting the client-side interface, with HTML for the structural foundation, CSS for the presentation layer, and JavaScript for dynamic functionality.

## Acknowledgments

- OpenAI's ChatGPT for providing initial guidance on project architecture.

Please note: these instructions are primarily for setting up a development environment. For deployment to a production environment, you might need to perform additional steps. These may include configuring a reverse proxy for the ASP.NET Core server, setting up a database for persistent game states, and implementing HTTPS protocols【5†source】.
