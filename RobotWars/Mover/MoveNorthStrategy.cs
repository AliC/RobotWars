using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class MoveNorthStrategy : IMover
    {
        private IEnumerable<Location> _possibleLocations;
        private readonly Location _location;

        public MoveNorthStrategy(IEnumerable<Location> possibleLocations, Location location)
        {
            _possibleLocations = possibleLocations;
            _location = location;
        }

        public Location Move()
        {
            Location newLocation = new Location(_location.X, _location.Y + 1);

            if (_possibleLocations.Contains(newLocation))
            {
                return newLocation;
            }

            return _location;
        }
    }
}