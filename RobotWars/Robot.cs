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

            if (instruction == 'R')
            {
                Heading++;
            }

            if (instruction == 'M')
            {
                if (Heading.HeadingFoo == Headings.N)
                {
                    Location.X++;
                }

                if (Heading.HeadingFoo == Headings.S)
                {
                    Location.X--;
                }

                if (Heading.HeadingFoo == Headings.E)
                {
                    Location.Y++;
                }

                if (Heading.HeadingFoo == Headings.W)
                {
                    Location.Y--;
                }
            }
        }
    }
}