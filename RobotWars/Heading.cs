using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public struct Heading
    {
        private string _heading;
        private const string _headings = "NESW";

        public Heading(string heading)
        {
            _heading = heading;
        }

        public string HeadingFoo
        {
            get
            {
                return _heading;
            }
        }

        public static Heading operator ++(Heading operand)
        {
            string newHeading = Next(_headings, operand.HeadingFoo);

            return new Heading(newHeading);
        }

        public static Heading operator --(Heading operand)
        {
            string newHeading = Next(_headings.Reverse(), operand.HeadingFoo);

            return new Heading(newHeading);
        }

        private static string Next(IEnumerable<char> headings, string headingFoo)
        {
            char newHeading;

            IEnumerable<char> nextHeading = headings.SkipWhile(h => !(h == headingFoo[0])).Skip(1);

            if (nextHeading.Any())
            {
                newHeading = nextHeading.First();
            }
            else
            {
                newHeading = headings.First();
            }

            return newHeading.ToString();
        }
    }
}