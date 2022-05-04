using MartianRobots.Command;
using System;
using System.Collections.Generic;

namespace MartianRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Resource.UserInputGrid);
                var gridSizeStr = Console.ReadLine();
                MrGrid grid = MrFactoryFinder.GridFactory.Create(gridSizeStr);


                List<MrRobot> robots = new List<MrRobot>();
                while (true)
                {
                    string messageRobot = String.Format(Resource.UserInputRobot, robots.Count + 1);
                    Console.WriteLine(messageRobot);

                    var robotPosStr = Console.ReadLine();
                    if (robotPosStr == Resource.UserRobotStateFinish)
                        break;

                    MrRobot robot = MrFactoryFinder.RobotFactory.Create(robotPosStr);

                    if(robot.CurrentCell.IndexX >grid.LimitX)
                        throw new Exception(Resource.ErrorRobotIndex);

                    if (robot.CurrentCell.IndexY > grid.LimitY)
                        throw new Exception(Resource.ErrorRobotIndex);

                    string messageCommands = String.Format(Resource.UserInputCommand, robots.Count + 1);
                    Console.WriteLine(messageCommands);

                    var commandsStr = Console.ReadLine();
                    if (commandsStr == Resource.UserRobotStateFinish)
                        break;

                    MrCommand[] mrCommands = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr, grid);
                    foreach (MrCommand command in mrCommands)
                    {
                        command.Move(robot);
                    }

                    robots.Add(robot);
                }

                foreach (MrRobot robo in robots)
                {
                    Console.WriteLine(robo);
                }

                Console.WriteLine(Resource.UserThanks);


                var exitStr = "";
                while (exitStr != Resource.UserExitCommand)
                {
                    Console.WriteLine(Resource.UserExitMessage);
                    exitStr = Console.ReadLine();
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            



        }
    }
}
