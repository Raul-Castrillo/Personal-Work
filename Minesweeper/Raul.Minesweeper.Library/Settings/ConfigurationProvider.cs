using System;
using System.Configuration;

namespace Raul.Minesweeper.Library.Settings
{
    class ConfigurationProvider : IConfigurationProvider
    {
        public T Get<T>(string name)
        {
            var result = default(T);
            try
            {
                result = (T)Convert.ChangeType(ConfigurationManager.AppSettings[name], typeof(T));
            }
            catch (Exception ex)
            {
                //TODO create logger and initialize it on Progam/Global.asax
                throw;
            }
            return result;
        }
    }
}
