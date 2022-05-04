using MartianRobots;
using MartianRobots.Command;
using MartianRobots.Direction;
using NUnit.Framework;

namespace MartianRobotsTestProject
{
    public class Tests
    {
        MrRobot robot1;
        MrRobot robot2;
        MrRobot robot3;

        MrCommand[] commands1;
        MrCommand[] commands2;
        MrCommand[] commands3;
        MrCommand[] commands4;
        MrCommand[] commands5;
        MrCommand[] commands6;
        MrCommand[] commands7;

        [SetUp]
        public void Setup()
        {
            MrGrid grid = new MrGrid(5, 3);

            MrCell cell1 = new MrCell(1, 1);
            MrDirection dir1 = new MrEastDirection();

            MrCell cell2 = new MrCell(3, 2);
            MrDirection dir2 = new MrNorthDirection();

            MrCell cell3 = new MrCell(0, 3);
            MrDirection dir3 = new MrWestDirection();

            robot1 = new MrRobot(cell1, dir1);
            robot2 = new MrRobot(cell2, dir2);
            robot3 = new MrRobot(cell3, dir3);


            string commandsStr1 = "RFRFRFRF";
            commands1 = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr1, grid);

            string commandsStr2 = "FRRFLLFFRRFLL";
            commands2 = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr2, grid);

            string commandsStr3 = "LLFFFLFLFL";
            commands3 = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr3, grid);

            string commandsStr4 = "LLFFRRRR";
            commands4 = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr4, grid);

            string commandsStr5 = "LFFRFFRRR";
            commands5 = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr5, grid);

            string commandsStr6 = "RFFFLFF";
            commands6 = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr6, grid);

            string commandsStr7 = "RRFFFFFRFLFFLF";
            commands7 = MrFactoryFinder.CommandFactory.CreateCommands(commandsStr7, grid);
        }

        [Test]
        public void SingleTest1()
        {
            foreach (MrCommand command in commands1)
            {
                command.Move(robot1);
            }
            Assert.That(robot1.ToString() == "1 1 E");
        }

        [Test]
        public void SingleTest2()
        {
            foreach (MrCommand command in commands2)
            {
                command.Move(robot2);
            }

            Assert.That(robot2.ToString() == "3 3 N LOST");
        }

        [Test]
        public void SingleTest3()
        {
            foreach (MrCommand command in commands3)
            {
                command.Move(robot3);
            }

            Assert.That(robot3.ToString() == "3 3 N LOST");
        }

        [Test]
        public void GivenTest()
        {
            foreach (MrCommand command in commands1)
            {
                command.Move(robot1);
            }

            foreach (MrCommand command in commands2)
            {
                command.Move(robot2);
            }

            foreach (MrCommand command in commands3)
            {
                command.Move(robot3);
            }

            Assert.That(robot1.ToString() == "1 1 E");
            Assert.That(robot2.ToString() == "3 3 N LOST");
            Assert.That(robot3.ToString() == "2 3 S");
        }

        [Test]
        public void FallLeft()
        {
            foreach (MrCommand command in commands4)
            {
                command.Move(robot1);
            }
            Assert.That(robot1.ToString() == "0 1 W LOST");
        }


        [Test]
        public void FallLeftCombine()
        {
            foreach (MrCommand command in commands4)
            {
                command.Move(robot1);
            }

            foreach (MrCommand command in commands5)
            {
                command.Move(robot3);
            }

            Assert.That(robot3.ToString() == "0 1 S");
        }

        [Test]
        public void FallRight()
        {
            foreach (MrCommand command in commands6)
            {
                command.Move(robot2);
            }
            Assert.That(robot2.ToString() == "5 2 E LOST");
        }

        [Test]
        public void FallRightCombine()
        {
            foreach (MrCommand command in commands6)
            {
                command.Move(robot2);
            }

            foreach (MrCommand command in commands7)
            {
                command.Move(robot3);
            }
            Assert.That(robot3.ToString() == "5 3 N");
        }
    }
}
