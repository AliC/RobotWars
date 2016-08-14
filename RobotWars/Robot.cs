using System;

namespace RobotWars
{
    public class Robot
    {
        public Location Location { get; set; }

        public Heading Heading { get; set; }

        public int Penalties { get; set; }

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
                if (Heading.HeadingFoo == "N")
                {
                    Location.Y++;
                }

                if (Heading.HeadingFoo == "S")
                {
                    Location.Y--;
                }

                if (Heading.HeadingFoo == "E")
                {
                    Location.X++;
                }

                if (Heading.HeadingFoo == "W")
                {
                    Location.X--;
                }
            }
        }
    }
}