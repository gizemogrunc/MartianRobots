namespace MartianRobots.Direction
{
    public class MrNorthDirection : MrDirection
    {
        private readonly MrCell _addedCellValue = new MrCell(0, 1);
        public override MrCell AddedCellValue
        {
            get { return _addedCellValue; }
        }
        public override MrDirection Left()
        {
            return new MrWestDirection();
        }

        public override MrDirection Right()
        {
            return new MrEastDirection();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
