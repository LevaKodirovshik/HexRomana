using System.Threading;

namespace HexRomana.Engine
{
    /// <summary>
    /// Immutable
    /// </summary>
    public abstract class Transformation
    {
        public ETransformationState State { get; protected init; }
        public uint Id { get; protected init; }
        protected Transformation()
        {
            Id = GenerateThreadSafeNewId();
        }
        private static uint _lastGeneratedId = 0;
        protected static uint GenerateThreadSafeNewId() => Interlocked.Increment(ref _lastGeneratedId);
    }
}
