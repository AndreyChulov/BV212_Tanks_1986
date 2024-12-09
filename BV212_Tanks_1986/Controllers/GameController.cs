using BV212_Tanks_1986.Game.Interfaces;
using BV212_Tanks_1986.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV212_Tanks_1986.Controllers;

public class GameController(IGameManager _gameManager) : Controller
{
    public void Lobby()
    {
        
    }
    
    public IActionResult Game()
    {
        var game = _gameManager.GetGameTanks(null);
        var dataModel = new GameModel(game);
        return View(dataModel);
    }
    
}