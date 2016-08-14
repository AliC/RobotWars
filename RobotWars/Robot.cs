using System;
using System.Linq;

namespace RobotWars
{
    public class Robot
    {
        private BattleArena _battleArena;

        public Location Location { get; set; }

        public Heading Heading { get; set; }

        public int Penalties { get; set; }

        public string CurrentStatus
        {
            get
            {
                return string.Join(" ", Location.X, Location.Y, Heading.Value);
            }
        }

        public Robot(BattleArena battleArena)
        {
            _battleArena = battleArena;
        }

        public void Navigate(char instruction)
        {
            if (instruction == 'L')
            {
                Heading--;
            }
            else if (instruction == 'R')
            {
                Heading++;
            }
            else if (instruction == 'M')
            {
                if (Heading.Value == "N")
                {
                    Location newLocation = new Location(Location.X, Location.Y + 1);

                    if (_battleArena.Boundary.Locations.Contains(newLocation))
                    {
                        Location = newLocation;
                    }
                    else
                    {
                        Penalties++;
                    }
                }

                if (Heading.Value == "S")
                {
                    Location newLocation = new Location(Location.X, Location.Y - 1);

                    if (_battleArena.Boundary.Locations.Contains(newLocation))
                    {
                        Location = newLocation;
                    }
                    else
                    {
                        Penalties++;
                    }
                }

                if (Heading.Value == "E")
                {
                    Location newLocation = new Location(Location.X + 1, Location.Y);

                    if (_battleArena.Boundary.Locations.Contains(newLocation))
                    {
                        Location = newLocation;
                    }
                    else
                    {
                        Penalties++;
                    }
                }

                if (Heading.Value == "W")
                {
                    Location newLocation = new Location(Location.X - 1, Location.Y);

                    if (_battleArena.Boundary.Locations.Contains(newLocation))
                    {
                        Location = newLocation;
                    }
                    else
                    {
                        Penalties++;
                    }
                }
            }
        }
    }
}