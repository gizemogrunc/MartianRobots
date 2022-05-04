using MartianRobots.Direction;
using System;

namespace MartianRobots.Robot
{
    public class MrRobotFactory
    {
        public  MrRobot Create(string robotStr)
        {
            string[] vs2 = robotStr.Split(' ');
            int indexX = -1;
            int indexY = -1;
            bool success = Int32.TryParse(vs2[0], out indexX);
            if(!success)
                throw new Exception(Resource.UnrecognizedRobotIndex);

            success = Int32.TryParse(vs2[1], out indexY);
            if (!success)
                throw new Exception(Resource.UnrecognizedRobotIndex);


            MrCell robotCell = new MrCell(indexX, indexY);

            MrDirection robotCurrentDir = null;
            switch (vs2[2])
            {
                case "W":
                    robotCurrentDir = new MrWestDirection();
                    break;
                case "E":
                    robotCurrentDir = new MrEastDirection();
                    break;
                case "N":
                    robotCurrentDir = new MrNorthDirection();
                    break;
                case "S":
                    robotCurrentDir = new MrSouthDirection();
                    break;
                default:
                    throw new Exception(Resource.UnrecognizedRobotDirection);

            }

            return new MrRobot(robotCell, robotCurrentDir);
        }

    }
}
