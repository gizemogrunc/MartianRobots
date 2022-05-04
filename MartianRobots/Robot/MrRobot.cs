using MartianRobots.Direction;

namespace MartianRobots
{
    public class MrRobot
    {
        private MrCell _currentCell;
        private MrDirection _currentDirection;
        private bool _fall;

        public MrRobot(MrCell currentCell, MrDirection currentDirection)
        {         
            _currentCell = currentCell;
            _currentDirection = currentDirection;
            
        }

        public MrDirection CurrentDirection
        {
            get { return _currentDirection; }
            set { _currentDirection = value; }
        }

        public MrCell CurrentCell
        {
            get { return _currentCell; }
            set { _currentCell = value; }
        }

        public bool Fall
        {
            get { return _fall; }
            set { _fall = value; }
        }

        public override string ToString()
        {
            string robotStr = CurrentCell.ToString() + " " + CurrentDirection.ToString();
            robotStr += Fall ? " LOST" : "";
            return robotStr;
        }

    }
}
