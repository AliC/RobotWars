namespace RobotWars
{
    public class Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Location location)
        {
            return location != null && X == location.X && Y == location.Y;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Location);
        }

        public static bool operator ==(Location first, Location second)
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            if (((object)first == null || (object)second == null))
            {
                return false;
            }

            return first.Equals(second);
        }

        public static bool operator !=(Location first, Location second)
        {
            return !(first == second);
        }

        public override int GetHashCode()
        {
            return X * 31 + Y;
        }
    }
}