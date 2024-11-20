using BV212_Tanks_1986.Game.Interfaces;

namespace BV212_Tanks_1986.Game;

public class GameTanks : IGameTanks
{
    public GameField GameField { get; private set; }
    
    public void StartGame()
    {
        GameField = new GameField();
    }

    public void EndGame()
    {
        throw new NotImplementedException();
    }
}