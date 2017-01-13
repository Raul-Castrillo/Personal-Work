using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Raul.Library.Settings;

namespace Minesweeper.Windsor
{
    public class WebInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IConfigurationProvider>()
                    .ImplementedBy<ConfigurationProvider>());
            //TODO it CAN'T BE SINGLETON
        }
    }
}