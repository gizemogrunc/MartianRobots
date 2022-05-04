using MartianRobots.Command;
using MartianRobots.Grid;
using MartianRobots.Robot;

namespace MartianRobots
{
    public class MrFactoryFinder
    {
        private static MrCommandFactory _commandFactory;
        private static MrRobotFactory _robotFactory;
        private static MrGridFactory _gridFactory;

        public static MrCommandFactory CommandFactory => _commandFactory ?? (_commandFactory = new MrCommandFactory());
        public static MrRobotFactory RobotFactory => _robotFactory ?? (_robotFactory = new MrRobotFactory());
        public static MrGridFactory GridFactory => _gridFactory ?? (_gridFactory = new MrGridFactory());

    }
}
