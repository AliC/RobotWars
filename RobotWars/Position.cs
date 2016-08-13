namespace RobotWars
{
    public class Location
    {
        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; internal set; }
        public int Y { get; internal set; }
    }
}