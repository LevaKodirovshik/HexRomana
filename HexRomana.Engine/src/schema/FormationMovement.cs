using System;

namespace HexRomana.Engine
{
    /// <summary>
    /// Immutable
    /// </summary>
    public class FormationMovement : Transformation
    {
        private XYTuple[] _wayPoints;
        public ReadOnlySpan<XYTuple> WayPoints => _wayPoints;
        public XYTuple From => _wayPoints[0];
        public XYTuple To => _wayPoints[_wayPoints.Length - 1];
        public Formation Formation { get; }
        public FormationMovement(Formation formation, XYTuple from, XYTuple to)
            : base()
        {
            if (from == to)
            {
                throw new ArgumentOutOfRangeException("Cannot move from/to same position without any other intermediate waypoints");
            }
            Formation = formation;
            _wayPoints = new XYTuple[] { from, to };
            State = ETransformationState.Intent;
        }
    }
}
