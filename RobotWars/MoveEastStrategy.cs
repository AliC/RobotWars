using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class MoveEastStrategy : IMover
    {
        private IEnumerable<Location> _possibleLocations;
        private readonly Location _location;

        public MoveEastStrategy(IEnumerable<Location> possibleLocations, Location location)
        {
            _possibleLocations = possibleLocations;
            _location = location;
        }

        public Location Move()
        {
            Location newLocation = new Location(_location.X + 1, _location.Y);

            if (_possibleLocations.Contains(newLocation))
            {
                return newLocation;
            }

            return _location;
        }
    }
}