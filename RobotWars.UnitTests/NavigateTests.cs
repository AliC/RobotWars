using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RobotWars.UnitTests
{

    [TestFixture]
    public class NavigateTests
    {
        [Test]
        public void Given_Initial_Location_Of_02E_When_Instructions_Are_MLMRMMMRMMRR_Then_Final_Location_And_Penalty_Count_Is_41N0()
        {
            Location initialLocation = new Location(0, 2);
            Heading initialHeading = new Heading("E");

            Location expectedLocation = new Location(4, 1);
            Heading expectedHeading = new Heading("N");
            int expectedPenalties = 0;

            string movementInstructions = "MLMRMMMRMMRR";

            BattleArena battleArena = new BattleArena();
            Robot robot = new Robot(battleArena);

            battleArena.PlaceRobot(robot, initialLocation, initialHeading);

            Trace.WriteLine(robot.CurrentStatus);

            foreach (char instruction in movementInstructions)
            {
                robot.Navigate(instruction);

                Trace.WriteLine(robot.CurrentStatus);
            }

            Assert.That(robot.Location.X, Is.EqualTo(expectedLocation.X));
            Assert.That(robot.Location.Y, Is.EqualTo(expectedLocation.Y));
            Assert.That(robot.Heading.Value, Is.EqualTo(expectedHeading.Value));
            Assert.That(robot.Penalties, Is.EqualTo(expectedPenalties));
        }
        
        [Test]
        public void Given_Initial_Location_Of_44S_When_Instructions_Are_LMLLMMLMMMRMM_Then_Final_Location_And_Penalty_Count_Is_01W1()
        {
            Location initialLocation = new Location(4, 4);
            Heading initialHeading = new Heading("S");

            Location expectedLocation = new Location(0, 1);
            Heading expectedHeading = new Heading("W");
            int expectedPenalties = 1;

            string movementInstructions = "LMLLMMLMMMRMM";

            BattleArena battleArena = new BattleArena();
            Robot robot = new Robot(battleArena);

            battleArena.PlaceRobot(robot, initialLocation, initialHeading);

            Trace.WriteLine(robot.CurrentStatus);

            foreach (char instruction in movementInstructions)
            {
                robot.Navigate(instruction);

                Trace.WriteLine(robot.CurrentStatus);
            }

            Assert.That(robot.Location.X, Is.EqualTo(expectedLocation.X));
            Assert.That(robot.Location.Y, Is.EqualTo(expectedLocation.Y));
            Assert.That(robot.Heading.Value, Is.EqualTo(expectedHeading.Value));
            Assert.That(robot.Penalties, Is.EqualTo(expectedPenalties));
        }

        [Test]
        public void Given_Initial_Location_Of_22W_When_Instructions_Are_MLMLMLMRMRMRMRM_Then_Final_Location_And_Penalty_Count_Is_22N0()
        {
            Location initialLocation = new Location(2, 2);
            Heading initialHeading = new Heading("W");

            Location expectedLocation = new Location(2, 2);
            Heading expectedHeading = new Heading("N");
            int expectedPenalties = 0;

            string movementInstructions = "MLMLMLMRMRMRMRM";

            BattleArena battleArena = new BattleArena();
            Robot robot = new Robot(battleArena);

            battleArena.PlaceRobot(robot, initialLocation, initialHeading);

            Trace.WriteLine(robot.CurrentStatus);

            foreach (char instruction in movementInstructions)
            {
                robot.Navigate(instruction);

                Trace.WriteLine(robot.CurrentStatus);
            }

            Assert.That(robot.Location.X, Is.EqualTo(expectedLocation.X));
            Assert.That(robot.Location.Y, Is.EqualTo(expectedLocation.Y));
            Assert.That(robot.Heading.Value, Is.EqualTo(expectedHeading.Value));
            Assert.That(robot.Penalties, Is.EqualTo(expectedPenalties));
        }

        [Test]
        public void Given_Initial_Location_Of_13N_When_Instructions_Are_MMLMMLMMMMM_Then_Final_Location_And_Penalty_Count_Is_00S3()
        {
            Location initialLocation = new Location(1, 3);
            Heading initialHeading = new Heading("N");

            Location expectedLocation = new Location(0, 0);
            Heading expectedHeading = new Heading("S");
            int expectedPenalties = 3;

            string movementInstructions = "MMLMMLMMMMM";

            BattleArena battleArena = new BattleArena();
            Robot robot = new Robot(battleArena);

            battleArena.PlaceRobot(robot, initialLocation, initialHeading);

            Trace.WriteLine(robot.CurrentStatus);

            foreach (char instruction in movementInstructions)
            {
                robot.Navigate(instruction);

                Trace.WriteLine(robot.CurrentStatus);
            }

            Assert.That(robot.Location.X, Is.EqualTo(expectedLocation.X));
            Assert.That(robot.Location.Y, Is.EqualTo(expectedLocation.Y));
            Assert.That(robot.Heading.Value, Is.EqualTo(expectedHeading.Value));
            Assert.That(robot.Penalties, Is.EqualTo(expectedPenalties));
        }
    }
}
