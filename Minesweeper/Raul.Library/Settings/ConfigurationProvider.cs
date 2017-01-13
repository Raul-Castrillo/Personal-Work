using System;
using System.Configuration;

namespace Raul.Library.Settings
{
    public class ConfigurationProvider : IConfigurationProvider
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
                Logger.Logger.Instance.Error("Error on configuration provider. Name={0} could not be found on configuration", name);
                throw ex;
            }
            return result;
        }
    }
}
