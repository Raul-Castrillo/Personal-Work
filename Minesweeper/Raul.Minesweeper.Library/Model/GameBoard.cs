using Raul.Minesweeper.Library.Enums;
using System.Configuration;

namespace Raul.Minesweeper.Library.Model
{
    public class GameBoard
    {
        public GameBoardParameters Parameters { get; set; }
        public Cell[,] Cells { get; set; }

        public GameBoard(Difficulty difficulty)
        {
            var test = ConfigurationManager.AppSettings["DifficultyValues"];
        }

        public void OpenCell(int x, int y)
        {
            if (!IsValidateCellCoordinates(x, y))
            {
                return;
            }
            if (Cells[x, y].IsOpened)
            {
                //TODO LOG
                return;
            }
            if (Cells[x, y].IsMarkedAsBomb)
            {
                return;
            }
            Cells[x, y].IsOpened = true;
            if (Cells[x, y].IsBomb)
            {
                FinishGame();
                return;
            }
            if (Cells[x, y].Value == 0)
            {
                ExpandOpen(x, y);
            }
        }

        public void MarkAsBomb(int x, int y)
        {
            //TODO add functionality of Clean-Flag-QuestionMark
            if(!IsValidateCellCoordinates(x,y))
            {
                return;
            }
            if (Cells[x, y].IsOpened)
            {
                //TODO LOG
                return;
            }
            Cells[x, y].IsMarkedAsBomb = !Cells[x, y].IsMarkedAsBomb;
        }

        private void ExpandOpen(int x, int y)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    OpenCell(x + i, y + j);
                }
            }
        }

        private void FinishGame()
        {
            //TODO
        }

        private bool IsValidateCellCoordinates(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                //TODO Logger.
                return false;
            }
            if (x >= Parameters.Size || y >= Parameters.Size)
            {
                //TOdo logger
                return false;
            }
            return true;
        }
    }
}
