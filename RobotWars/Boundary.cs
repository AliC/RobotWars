using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class Boundary
    {
        public Boundary()
        {
            Positions = GeneratePositions(5, 5).ToList();
        }

        public IList<Position> Positions { get; set; }

        private IEnumerable<Position> GeneratePositions(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    yield return new Position(i, j);
                }

            }
        }
    }
}