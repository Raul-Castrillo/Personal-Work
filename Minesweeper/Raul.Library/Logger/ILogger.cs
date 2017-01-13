using System;

namespace Raul.Library.Logger
{
    public interface ILogger
    {
        void Info(string message);

        void Info(string message, Exception ex);

        void Error(string message);

        void Error(string message, Exception ex);
    }
}
