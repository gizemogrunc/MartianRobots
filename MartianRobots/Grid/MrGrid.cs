using System.Collections.Generic;
using System.Linq;

namespace MartianRobots
{
    public class MrGrid
    {
        private List<MrCell> borderCells = new List<MrCell>();
        private int _x;
        private int _y;

        public MrGrid(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public List<MrCell> BorderCells
        {
            get { return borderCells; }
        }
            
        public int LimitX 
        {
            get { return _x; }
        }
        public int LimitY
        {
            get { return _y; }
        }
    }


}
