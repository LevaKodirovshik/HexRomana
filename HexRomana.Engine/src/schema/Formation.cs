using System;

namespace HexRomana.Engine
{
    /// <summary>
    /// Immutable
    /// </summary>
    public class Formation
    {
        public string Name { get; }
        public EFormationScale Scale { get; }
        public Officer Commander { get; }
        public ESpecialization Specialization { get; }
        private readonly Formation[] _constituentFormations;
        public ReadOnlySpan<Formation> ConstituentFormations => _constituentFormations;
        public Faction Faction { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="scale"></param>
        /// <param name="commander"></param>
        /// <param name="specialization"></param>
        /// <param name="constituentFormations">substituted with an empty array if null</param>
        /// <param name="faction"></param>
        public Formation(
            string name,
            EFormationScale scale,
            Officer commander,
            ESpecialization specialization,
            Formation[] constituentFormations,
            Faction faction)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Scale = scale;
            Commander = commander ?? throw new ArgumentNullException(nameof(commander));
            Specialization = specialization;
            _constituentFormations = constituentFormations.EmptyIfNull();
            Faction = faction ?? throw new ArgumentNullException(nameof(faction));
        }
    }
}
