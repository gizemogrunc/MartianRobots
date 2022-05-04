using System;
using System.Collections.Generic;

namespace MartianRobots.Command
{
    public class MrCommandFactory
    {
        public  MrCommand Create(char commandStr, MrGrid grid)
        {
            switch (commandStr)
            {
                case 'L':
                    return new MrLeftCommand(grid);
                case 'R':
                    return new MrRightCommand(grid);
                case 'F':
                    return new MrForwardCommand(grid);
                default:
                    throw new Exception(Resource.UnrecognizedCommand);


            }

            return null;
        }

        public  MrCommand[] CreateCommands(string commandsStr, MrGrid grid)
        {
            var commands = commandsStr.ToCharArray();
            List<MrCommand> listOfCommands = new List<MrCommand>();
            foreach (var commandStr in commands)
            {
                listOfCommands.Add(Create(commandStr, grid));
            }
            return listOfCommands.ToArray();
        }
    }
}
