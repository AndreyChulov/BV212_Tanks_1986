namespace BV212_Tanks_1986.Game.Interfaces;

public interface IGameManager
{
    IGameTanks GetGameTanks(IGameCredentials? credentials);
    void InitGameTanks(IGameCredentials? credentials);
}