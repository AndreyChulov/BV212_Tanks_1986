using BV212_Tanks_1986.Game.Interfaces;
using BV212_Tanks_1986.Models.Enums;

namespace BV212_Tanks_1986.Models;

public class GameFieldModel
{
    public int FieldWidth { get; private set; }
    public int FieldHeight { get; private set; }
    public CellTile[][] Map { get; private set; }
    
    public GameFieldModel(IGameTanks game)
    {
        FieldHeight = game.GameField.FieldHeight;
        FieldWidth = game.GameField.FieldWidth;

        Map = game.GameField.Map.
            Select(x=> 
                x.Select(y => y.ToCellTile()).ToArray()
                ).ToArray();
    }
}