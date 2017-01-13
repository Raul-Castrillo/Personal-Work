using Castle.Windsor;
using Minesweeper.Windsor;
using Raul.Library.Logger;
using Raul.Library.Settings;
using System;
using System.Web.Mvc;

namespace Raul.Minesweeper.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            if (TryInitializeLogger())
            {
                //TODO OTHER
            }
        }
                
        private static bool TryInitializeLogger()
        {
            try
            {
                var container = new WindsorContainer();
                container.Install(
                   new WebInstaller()
                );
                var configProvider = container.Resolve<IConfigurationProvider>();
                var loggingPath = configProvider.Get<string>("LoggingPath");
                var logger = new Logger();
                logger.Initialize(loggingPath);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
