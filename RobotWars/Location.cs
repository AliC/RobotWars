using System;

namespace RobotWars
{
    public class Location
    {
        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public bool Equals(Location location)
        {
            return location != null && X == location.X && Y == location.Y;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Location);
        }
        
        public override int GetHashCode()
        {
            return X * 31 + Y;
        }
    }
}