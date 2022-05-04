namespace MartianRobots.Direction
{
    public class MrWestDirection : MrDirection
    {
        private readonly MrCell _addedCellValue = new MrCell(-1, 0);
        public override MrCell AddedCellValue
        {
            get { return _addedCellValue; }
        }

        public override MrDirection Left()
        {
            return new MrSouthDirection();
        }
        public override MrDirection Right()
        {
            return new MrNorthDirection();
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
