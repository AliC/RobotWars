using System.Collections.Generic;

namespace RobotWars
{
    public class MoverFactory
    {
        public static IMover Create(IList<Location> possibleLocations, string heading, Location location)
        {
            if (heading == "N")
            {
                return new MoveNorthStrategy(possibleLocations, location);
            }

            if (heading == "S")
            {
                return new MoveSouthStrategy(possibleLocations, location);
            }

            if (heading == "E")
            {
                return new MoveEastStrategy(possibleLocations, location);
            }

            if (heading == "W")
            {
                return new MoveWestStrategy(possibleLocations, location);
            }

            return null;
        }
    }
}