namespace MartianRobots.Command
{
    public class MrLeftCommand : MrCommand
    {
        public MrLeftCommand(MrGrid grid) : base(grid)
        {
        }

        public override bool IsRobotFall(MrRobot robot)
        {
            return false; //in every case there is no chance robot to fall 
        }

        public override bool IsValidToMove(MrRobot robot)
        {
            return true; //in every case there is no chance robot to fall 
        }

        protected override void onMove(MrRobot robot)
        {
            robot.CurrentDirection = robot.CurrentDirection.Left();
        }
    }
}
