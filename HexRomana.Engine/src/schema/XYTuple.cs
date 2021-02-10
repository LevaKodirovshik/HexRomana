using System;

namespace HexRomana.Engine
{
    public readonly struct XYTuple
    {
        public XYTuple(uint x, uint y)
        {
            X = x;
            Y = y;
        }

        public uint X { get; init; }
        public uint Y { get; init; }
        public uint x { get => X; }
        public uint y { get => Y; }
        public readonly bool Equals(in XYTuple other) => X == other.X && Y == other.Y;
        public override bool Equals(object? obj) => obj is XYTuple other && Equals(in other);
        public static bool operator ==(in XYTuple left, in XYTuple right) => left.Equals(in right);
        public static bool operator !=(in XYTuple left, in XYTuple right) => !left.Equals(in right);
        public override int GetHashCode() => HashCode.Combine(X, Y);
        public override string ToString() => $"Coordinates({X}, {Y})";
        public static implicit operator XYTuple((uint X, uint Y) source) => new(source.X, source.Y);
        public static implicit operator (uint X, uint Y)(XYTuple source) => (source.X, source.Y);
    }
}
