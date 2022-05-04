using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianRobots.Grid
{
    public class MrGridFactory
    {
        public MrGrid Create(string gridSizeStr)
        {
            string[] vs = gridSizeStr.Split(' ');
            int indexX = -1;
            int indexY = -1;
            bool parse = Int32.TryParse(vs[0], out indexX);
            if(!parse)
            {
                throw new Exception(Resource.UnrecognizedGridSize);
            }

            parse = Int32.TryParse(vs[1], out indexY);
            if (!parse)
            {
                throw new Exception(Resource.UnrecognizedGridSize);
            }

            MrGrid grid = new MrGrid(indexX, indexY);
            return grid;
        }
    }
}
