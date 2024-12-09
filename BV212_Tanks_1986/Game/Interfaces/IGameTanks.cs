namespace BV212_Tanks_1986.Game.Interfaces;

public interface IGameTanks
{
    GameField GameField { get; }
    
    void StartGame();
    void EndGame();
}