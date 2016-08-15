using System;
using NUnit.Framework;

namespace RobotWars.UnitTests
{
    [TestFixture]
    public class BattleArenaTests
    {
        [Test]
        public void When_Battle_Starts_Robot_Has_Initial_Location()
        {
            Location expectedLocation = new Location(0, 0);
            Heading expectedHeading = new Heading("N");

            BattleArena battleArena = new BattleArena();
            Robot robot = new Robot();

            battleArena.PlaceRobot(robot, expectedLocation, expectedHeading);

            Assert.That(robot.Location, Is.EqualTo(expectedLocation));
            Assert.That(robot.Heading, Is.EqualTo(expectedHeading));
        }

        [Test]
        public void BattleArena_Boundary_Should_Be_Five_By_Five()
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
