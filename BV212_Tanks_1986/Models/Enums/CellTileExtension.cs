using BV212_Tanks_1986.Game.Enums;

namespace BV212_Tanks_1986.Models.Enums;

public static class CellTileExtension
{
    private static Dictionary<GameCellTile, CellTile> _convertDictionary =
        new Dictionary<GameCellTile, CellTile>
        {
            { GameCellTile.Brick, CellTile.Brick },
            { GameCellTile.EnemyBase, CellTile.EnemyBase },
            { GameCellTile.FriendlyBase, CellTile.FriendlyBase },
            { GameCellTile.BadRock, CellTile.BadRock },
            { GameCellTile.Empty, CellTile.Empty },
        };
    
    public static CellTile ToCellTile(this GameCellTile source)
    {
        return _convertDictionary[source];
    }
}