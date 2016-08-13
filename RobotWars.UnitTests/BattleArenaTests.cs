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
        public void When_Battle_Starts_Robot_Has_Initial_Location()
        {
            Location expectedLocation = new Location(0, 0);
            string expectedHeading = "N";

            Robot robot = new Robot();
            BattleArena battleArena = new BattleArena();

            battleArena.PlaceRobot(robot, expectedLocation, expectedHeading);

            Assert.That(robot.Location, Is.EqualTo(expectedLocation));
            Assert.That(robot.Heading, Is.EqualTo(expectedHeading));
        }

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
