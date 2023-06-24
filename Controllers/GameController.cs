using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Hangman_Server.Models;

/*
[HttpPost("create")]
public async Task<IActionResult> CreateGame()
{
    var game = new Game();
    game = await _gameService.CreateGameAsync(game);
    return Ok(game.GameId);
}

[HttpPost("{gameId}/join")]
public async Task<IActionResult> JoinGame(int gameId, [FromBody] Player player)
{
    var game = await _gameService.JoinGameAsync(gameId, player);
    return Ok(game);
}

[HttpPost("{gameId}/guess")]
public async Task<IActionResult> Guess(int gameId, [FromBody] GuessRequest request)
{
    var game = await _gameService.GuessAsync(gameId, request.PlayerId, request.Guess);
    return Ok(game);
} */
