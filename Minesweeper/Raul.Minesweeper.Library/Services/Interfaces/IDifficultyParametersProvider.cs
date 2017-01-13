using Raul.Minesweeper.Library.Enums;
using Raul.Minesweeper.Library.Model;

namespace Raul.Minesweeper.Library.Services.Interfaces
{
    public interface IDifficultyParametersProvider
    {
        GameBoardParameters GetParameters(Difficulty difficulty);
    }
}
