using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public struct Heading
    {
        private const string _headings = "NESW";

        public string Value { get; set; }

        public Heading(string heading)
        {
            Value = heading;
        }
        
        public static Heading operator ++(Heading heading)
        {
            string newHeading = Next(_headings, heading.Value);

            return new Heading(newHeading);
        }

        public static Heading operator --(Heading heading)
        {
            string newHeading = Next(_headings.Reverse(), heading.Value);

            return new Heading(newHeading);
        }

        private static string Next(IEnumerable<char> headings, string heading)
        {
            char newHeading;

            IEnumerable<char> nextHeading = headings.SkipWhile(h => !(h == heading[0])).Skip(1);

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