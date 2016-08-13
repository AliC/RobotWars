using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RobotWars.UnitTests
{
    [TestFixture]
    class BattleArenaTests
    {
        [Test]
        public void Arena_Boundary_Should_Be_Five_By_Five()
        {

            BattleArena battleArena = new BattleArena();

            for (int i = 0; i < 25; i++)
            {
                Assert.That(battleArena.Boundary.Locations[i].X, Is.EqualTo(Math.Floor(i / 5m)));
                Assert.That(battleArena.Boundary.Locations[i].Y, Is.EqualTo(i % 5));
            }
        }
    }
}
