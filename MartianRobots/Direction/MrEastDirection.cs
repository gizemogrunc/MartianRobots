using MartianRobots.Direction;

namespace MartianRobots
{
    public class MrEastDirection : MrDirection
    {
        private readonly MrCell _addedCellValue = new MrCell(1, 0);

        public override MrCell AddedCellValue
        {
            get { return _addedCellValue; }
        }
        public override MrDirection Left()
        {
            return new MrNorthDirection();
        }

        public override MrDirection Right()
        {
            return new MrSouthDirection();
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
