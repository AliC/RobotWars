using System;

namespace RobotWars
{
    public class BattleArena
    {
        public BattleArena()
        {
            Boundary = new Boundary();
        }

        public Boundary Boundary { get; set; }

        public void PlaceRobot(Robot robot)
        {
            robot.Location = Boundary.Locations[0];
        }
    }
}