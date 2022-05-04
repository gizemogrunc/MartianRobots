namespace MartianRobots.Command
{
    public abstract class MrCommand
    {
        protected MrGrid Grid;

        public MrCommand(MrGrid grid)
        {
            Grid = grid;
        }

        public void Move(MrRobot robot)
        {
            if (robot.Fall)
                return;

            if (!IsValidToMove(robot))
                return;

            if (IsRobotFall(robot))
            {
                robot.Fall = true;
                return;
            }

            onMove(robot);
        }

        protected abstract void onMove(MrRobot robot);

        public abstract bool IsValidToMove(MrRobot robot);

        public abstract bool IsRobotFall(MrRobot robot);

    }
}
