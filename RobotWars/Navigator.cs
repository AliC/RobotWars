namespace RobotWars
{
    public class Navigator
    {
        private readonly BattleArena _battleArena;
        private readonly Robot _robot;

        public Navigator(BattleArena battleArena, Robot robot)
        {
            _battleArena = battleArena;
            _robot = robot;
        }

        public void Navigate(char instruction)
        {
            if (instruction == 'L')
            {
                _robot.Heading--;
            }
            else if (instruction == 'R')
            {
                _robot.Heading++;
            }
            else if (instruction == 'M')
            {
                IMover mover = MoverFactory.Create(_battleArena.Boundary.Locations, _robot.Heading.Value, _robot.Location);

                Location currentLocation = new Location(_robot.Location.X, _robot.Location.Y);
                _robot.Location = mover.Move();

                if(currentLocation == _robot.Location)
                {
                    _robot.Penalties++;
                }
            }
        }
    }
}