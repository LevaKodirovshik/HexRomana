using System;

namespace HexRomana.Engine
{
    /// <summary>
    /// Immutable
    /// </summary>
    public class Cell
    {
        private readonly TerrainFeature[] _terrain;
        public ReadOnlySpan<TerrainFeature> Terrain => _terrain;

        private readonly Formation[] _formations;
        public ReadOnlySpan<Formation> Formations => _formations;

        private Cell(TerrainFeature[] terrain, Formation[] formations)
        {
            _terrain = terrain;
            _formations = formations;
        }
        public static Cell Empty { get; } = new Cell(Array.Empty<TerrainFeature>(), Array.Empty<Formation>());
    }
}
