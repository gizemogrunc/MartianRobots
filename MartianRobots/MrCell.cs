namespace MartianRobots
{
    public class MrCell
    {
        private int _indexX = 0;
        private int _indexY = 0;

        public MrCell(int x, int y)
        {
            _indexX = x;
            _indexY = y;
        }

        public int IndexX => _indexX;
        public int IndexY => _indexY;


        public override string ToString()
        {
            return _indexX + " " + _indexY;
        }

    }
}
