using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class Boundary
    {
        public Boundary()
        {
            Locations = GenerateLocations(5, 5).ToList();
        }

        public IList<Location> Locations { get; set; }

        private IEnumerable<Location> GenerateLocations(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    yield return new Location(i, j);
                }

            }
        }
    }
}