using System.Collections.Generic;
using System.Linq;

namespace RobotWars
{
    public class MoverFactory
    {
        public static IMover Create(IList<Location> possibleLocations, string heading, Location location)
        {
            if (heading == "N")
            {
                return new MoveNorthStrategy(possibleLocations, location);
            }

            if (heading == "S")
            {
                return new MoveSouthStrategy(possibleLocations, location);
            }

            if (heading == "E")
            {
                return new MoveEastStrategy(possibleLocations, location);
            }

            if (heading == "W")
            {
                return new MoveWestStrategy(possibleLocations, location);
            }

            return null;
        }
    }

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

    public class MoveWestStrategy : IMover
    {
        private IEnumerable<Location> _possibleLocations;
        private readonly Location _location;

        public MoveWestStrategy(IEnumerable<Location> possibleLocations, Location location)
        {
            _possibleLocations = possibleLocations;
            _location = location;
        }

        public Location Move()
        {
            Location newLocation = new Location(_location.X - 1, _location.Y);

            if (_possibleLocations.Contains(newLocation))
            {
                return newLocation;
            }

            return _location;
        }
    }
}