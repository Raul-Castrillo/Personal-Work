namespace Raul.Library.Settings
{
    public interface IConfigurationProvider
    {
        T Get<T>(string name);
    }
}
