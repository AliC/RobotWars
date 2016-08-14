using System;
using System.Collections.Generic;

namespace RobotWars
{
    public class Heading
    {
        private Headings _heading;

        public Heading(Headings heading)
        {
            _heading = heading;
        }

        public Headings HeadingFoo
        {
            get
            {
                return _heading;
            }
        }

        public static Heading operator ++(Heading operand)
        {
            Headings newHeading = operand.HeadingFoo + 90;

            return new Heading(newHeading);
        }

        public static Heading operator --(Heading operand)
        {
            Headings newHeading = operand.HeadingFoo - 90;

            return new Heading(newHeading);
        }

    }
}