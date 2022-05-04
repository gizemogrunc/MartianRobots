namespace MartianRobots.Direction
{
    public abstract class MrDirection
    {
        public abstract MrCell AddedCellValue { get; }
        public abstract MrDirection Left();
        public abstract MrDirection Right();
        public abstract string ToString();
    }




}
