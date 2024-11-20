using BV212_Tanks_1986.Game.Interfaces;

namespace BV212_Tanks_1986.Game;

public class GameManager : IGameManager
{
    private Dictionary<string, IGameTanks> _games = [];
    
    public IGameTanks GetGameTanks(IGameCredentials? credentials)
    {
        if (credentials != null) throw new NotImplementedException();

        if (!_games.TryGetValue("null", out var game))
        {
            throw new InvalidOperationException();
        }
        
        return game;
    }

    public void InitGameTanks(IGameCredentials? credentials)
    {
        if (credentials != null) throw new NotImplementedException();
        
        if (_games.ContainsKey("null"))
        {
            _games["null"].EndGame();
        }
        _games["null"] = new GameTanks();
        _games["null"].StartGame();
    }
}