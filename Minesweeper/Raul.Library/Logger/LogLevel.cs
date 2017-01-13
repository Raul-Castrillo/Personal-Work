using System.ComponentModel;

namespace Raul.Library.Logger
{
    public enum LogLevel
    {
        [Description("INFO")]
        Info,
        [Description("WARN")]
        Warn,
        [Description("ERROR")]
        Error
    }
}
