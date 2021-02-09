using System;

namespace HexRomana.Engine
{
    /// <summary>
    /// Immutable
    /// </summary>
    public class Map
    {
        public XYTuple Dimensions { get; init; }
        private readonly Cell[,] _cells;
        public Map(in XYTuple dimensions)
        {
            if (dimensions.X == 0 || dimensions.Y == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(dimensions), "x/y dimensions cannot be 0");
            }
            Dimensions = dimensions;
            _cells = new Cell[dimensions.X, dimensions.Y];
            for (int x = 0; x < dimensions.X; x++)
            {
                for (int y = 0; y < dimensions.Y; y++)
                {
                    _cells[x, y] = Cell.Empty;
                }
            }
        }

        public Cell this[in XYTuple coordinates]
        {
            get => _cells[coordinates.X, coordinates.Y];
        }
    }
}
