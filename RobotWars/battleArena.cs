using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class BattleArena
    {
        public BattleArena()
        {
            Boundary = new Boundary();
        }

        public Boundary Boundary { get; set; }

        public void PlaceRobot(Robot robot, Location initialLocation, Heading initialHeading)
        {
            if (Boundary.Locations.Any(l => l == initialLocation))
            {
                robot.Location = initialLocation;
                robot.Heading = initialHeading;
            }
        }
    }
}