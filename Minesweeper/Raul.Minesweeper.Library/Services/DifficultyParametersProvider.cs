using Raul.Library.Settings;
using Raul.Minesweeper.Library.Enums;
using Raul.Minesweeper.Library.Model;
using Raul.Minesweeper.Library.Services.Interfaces;

namespace Raul.Minesweeper.Library.Services
{
    public class DifficultyParametersProvider : IDifficultyParametersProvider
    {
        private readonly IConfigurationProvider _configurationProvider;
        public DifficultyParametersProvider(IConfigurationProvider configurationProvider)
        {
            _configurationProvider = configurationProvider;
        }
        public GameBoardParameters GetParameters(Difficulty difficulty)
        {
            var result = new GameBoardParameters();

            //TODO Assign string value to enum


            return result;
        }
    }
}
