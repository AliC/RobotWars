using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class MoveSouthStrategy : IMover
    {
        private IEnumerable<Location> _possibleLocations;
        private readonly Location _location;

        public MoveSouthStrategy(IEnumerable<Location> possibleLocations, Location location)
        {
            _possibleLocations = possibleLocations;
            _location = location;
        }

        public Location Move()
        {
            Location newLocation = new Location(_location.X, _location.Y - 1);

            if (_possibleLocations.Contains(newLocation))
            {
                return newLocation;
            }

            return _location;
        }
    }
}