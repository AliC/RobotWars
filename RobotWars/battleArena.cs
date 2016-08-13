﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class BattleArena
    {
        public BattleArena()
        {
            Boundary = new Boundary();
            Headings = new List<string>
            {
                "N",
                "S",
                "E",
                "W"
            };
        }

        public Boundary Boundary { get; set; }

        public IList<string> Headings { get; set; }

        public void PlaceRobot(Robot robot, Location initialLocation, string initialHeading)
        {
            if (Boundary.Locations.Any(l => l.X == initialLocation.X && l.Y == initialLocation.Y) && Headings.Any(h => h == initialHeading))
            {
                robot.Location = initialLocation;
                robot.Heading = initialHeading;
            }
        }
    }
}