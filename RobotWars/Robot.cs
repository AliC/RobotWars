namespace RobotWars
{
    public class Robot
    {
        public Location Location { get; set; }

        public Heading Heading { get; set; }

        public int Penalties { get; set; }

        public string CurrentStatus
        {
            get
            {
                return string.Join(" ", Location.X, Location.Y, Heading.Value, Penalties);
            }
        }
    }
}