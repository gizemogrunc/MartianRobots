using System.Linq;

namespace MartianRobots.Command
{
    public class MrForwardCommand : MrCommand
    {
        public MrForwardCommand(MrGrid grid) : base(grid)
        {
        }

        public override bool IsRobotFall(MrRobot robot)
        {
            var newIndexX = robot.CurrentCell.IndexX + robot.CurrentDirection.AddedCellValue.IndexX;
            var newIndexY = robot.CurrentCell.IndexY + robot.CurrentDirection.AddedCellValue.IndexY;

            if (newIndexX < 0 ||
                newIndexY < 0 ||
                newIndexX > Grid.LimitX ||
                newIndexY > Grid.LimitY)
            {
                Grid.BorderCells.Add(new MrCell(newIndexX, newIndexY));
                return true;
            }

          

            return false;
        }

        public override bool IsValidToMove(MrRobot robot)
        {
            var newIndexX = robot.CurrentCell.IndexX + robot.CurrentDirection.AddedCellValue.IndexX;
            var newIndexY = robot.CurrentCell.IndexY + robot.CurrentDirection.AddedCellValue.IndexY;            
            if (Grid.BorderCells.Any(cell => cell.IndexX == newIndexX && cell.IndexY == newIndexY))
                return false;

            return true;
        }

        protected override void onMove(MrRobot robot)
        {
            var newIndexX = robot.CurrentCell.IndexX + robot.CurrentDirection.AddedCellValue.IndexX;
            var newIndexY = robot.CurrentCell.IndexY + robot.CurrentDirection.AddedCellValue.IndexY;
            var newCell = new MrCell(newIndexX, newIndexY);
            robot.CurrentCell = newCell;
        }
    }
}
