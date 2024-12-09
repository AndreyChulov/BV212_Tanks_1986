using BV212_Tanks_1986.Game.Interfaces;
using BV212_Tanks_1986.Models;
using Microsoft.AspNetCore.Mvc;

namespace BV212_Tanks_1986.Controllers;

[ApiController]
[Route("api")]
public class ApiController(IProfile _profile, IGameManager _gameManager) : Controller
{
    [HttpPost()]
    [Route("login")]
    
    public IActionResult Login()// login, [FromBody]string password)
    {
        var request = HttpContext.Request;
        var login = Request.Form["username"];
        var password = Request.Form["password"];
        
        if (_profile.ValidateProfile(login, password))
        {
            return new RedirectToActionResult("Lobby", "Game", null);
        }
        
        return new JsonResult("Failure");
    }

    [HttpPost]
    [Route(nameof(StartGame))]
    public IActionResult StartGame()
    {
        var gameTanks = _gameManager.GetGameTanks(null);
        
        gameTanks.StartGame();
        
        var gameModel = new GameModel(gameTanks);

        return PartialView("GameField", gameModel.GameFieldModel);
    }

    public void Left()
    {
        
    }

    public void Right()
    {
        
    }

    public void Up()
    {
        
    }

    public void Down()
    {
        
    }
}