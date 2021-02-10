using System;
using System.Linq;
using Xunit;

namespace HexRomana.Engine.Test
{
    public class Schema
    {
        [Fact]
        public void XYTupleEquality()
        {
            var c1 = new XYTuple(1, 1);
            var c2 = new XYTuple { X = 1, Y = 1 };
            Assert.True(c1 == c2);
            Assert.True((c1 as object).Equals(c2));
            var c3 = new XYTuple { X = 2, Y = 2 };
            Assert.True(c1 != c3);
            Assert.False((c1 as object).Equals(c3));
        }
        [Fact]
        public void XYTupleHashing()
        {
            var c1 = new XYTuple { X = 1, Y = 1 };
            var c2 = new XYTuple { X = 1, Y = 1 };
            Assert.True(c1.GetHashCode() == c2.GetHashCode());

            var c3 = new XYTuple { X = 2, Y = 2 };
            Assert.True(c2.GetHashCode() != c3.GetHashCode());
        }
        [Fact]
        public void OfficerCreation()
        {
            new Officer("test officer", ERank.Centurion);
        }
        [Fact]
        public void FactionCreation()
        {
            new Faction("test faction");
        }
        [Fact]
        public void FormationCreation()
        {
            new Formation("test formation", EFormationScale.Century, new Officer("test officer", ERank.Centurion), ESpecialization.HeavyInfantry, null, new Faction("test faction"));
            Assert.Throws<ArgumentNullException>(() => new Formation(null, EFormationScale.Century, new Officer("test officer", ERank.Centurion), ESpecialization.HeavyInfantry, null, new Faction("test faction")));
            Assert.Throws<ArgumentNullException>(() => new Formation("test formation", EFormationScale.Century, null, ESpecialization.HeavyInfantry, null, new Faction("test faction")));
            Assert.Throws<ArgumentNullException>(() => new Formation("test formation", EFormationScale.Century, new Officer("test officer", ERank.Centurion), ESpecialization.HeavyInfantry, null, null));
        }
        [Fact]
        public void MapCreation()
        {
            var map = new Map(new(10, 10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Map(new(0, 0)));
            Assert.Equal(map[new(1, 1)], map[1, 1]);
            var firstCell = map.First();
        }
        [Fact]
        public void GameCreation()
        {
            new Game(new Map(new(10, 10)), null, null);
            Assert.Throws<ArgumentNullException>(() => new Game(null, null, null));
        }

    }
}
