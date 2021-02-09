using System;

namespace HexRomana.Engine
{
    /// <summary>
    /// Immutable
    /// </summary>
    public class Game
    {
        public Map Map { get; }
        private readonly Formation[] _formations;
        public ReadOnlySpan<Formation> Formations => _formations;
        private readonly Officer[] _officers;
        public ReadOnlySpan<Officer> Officers => _officers;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        /// <param name="formations">substituted with empty if null</param>
        /// <param name="officers">substituted with empty if null</param>
        public Game(Map map, Formation[] formations, Officer[] officers)
        {
            Map = map ?? throw new ArgumentNullException(nameof(map));
            _formations = formations.EmptyIfNull();
            _officers = officers.EmptyIfNull();
        }
    }
}
