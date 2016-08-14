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
            Heading initialHeading = new Heading(Headings.E);

            Location expectedLocation = new Location(4, 1);
            string expectedHeading = "N";
            int expectedPenalties = 0;

            //TODO ADC: consider using a Queue (FIFO)
            string movementInstructions = "MLMRMMMRMMRR";

            Robot robot = new Robot();
            BattleArena battleArena = new BattleArena();

            battleArena.PlaceRobot(robot, initialLocation, initialHeading);

            Trace.WriteLine(string.Join(" ", robot.Location.X, robot.Location.Y, robot.Heading.HeadingFoo));

            foreach (char instruction in movementInstructions)
            {
                robot.Navigate(instruction);

                Trace.WriteLine(string.Join(" ", robot.Location.X, robot.Location.Y, robot.Heading.HeadingFoo));
            }


            Assert.That(robot.Location.X, Is.EqualTo(expectedLocation.X));
            Assert.That(robot.Location.Y, Is.EqualTo(expectedLocation.Y));
            Assert.That(robot.Heading, Is.EqualTo(expectedHeading));
            Assert.That(robot.Penalties, Is.EqualTo(expectedPenalties));

        }
    }





    /*

Initial Position
Movements instructions
Final position and penalty count

Scenario 1
0, 2, E
MLMRMMMRMMRR
Position:	4, 1, N
Penalties: 	0 

    Scenario 2
4, 4, S
LMLLMMLMMMRMM
Position:	0, 1, W
Penalties: 	1

    Scenario 3
2, 2, W
MLMLMLM RMRMRMRM
Position:	2, 2, N
Penalties: 	0

    Scenario 4
1, 3, N
MMLMMLMMMMM
Position:	0, 0, S
Penalties: 	3



    */

}
