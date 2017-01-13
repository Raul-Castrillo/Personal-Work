using System;
using System.IO;

namespace Raul.Library.Logger
{
    public class Logger : ILogger
    {
        private static readonly Logger LoggerInstance = new Logger();
        private static string CompletePath;
        private static bool IsInitialized;

        public static ILogger Instance
        {
            get { return LoggerInstance; }
        }

        public void Initialize(string path)
        {
            var fileName = DateTime.Today.ToString("dd-MM-yyyy");
            try
            {
                CompletePath = string.Format(@"{0}\{1}.txt", path, fileName);
                FileInfo file = new System.IO.FileInfo(CompletePath);
                file.Directory.Create();
                string initialMessage = "Program starts. Logger initialized successfully.";
                IsInitialized = true;
                LogMessage(initialMessage, LogLevel.Info);                
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                throw new Exception(string.Format("Error initializing Logger component. Exception: {0}", ex));
            }
        }

        public void Error(string message)
        {
            LogMessage(message, LogLevel.Error);
        }

        public void Error(string message, Exception ex)
        {
            LogMessage(string.Format("{0} {1}", message, ExtractExceptionMessage(ex)), LogLevel.Error);
        }

        public void Error(string message, params object[] args)
        {
            LogMessage(string.Format(message, args), LogLevel.Error);
        }

        public void Info(string message)
        {
            LogMessage(message, LogLevel.Info);
        }

        public void Info(string message, Exception ex)
        {
            LogMessage(string.Format("{0} {1}", message, ExtractExceptionMessage(ex)), LogLevel.Info);
        }

        public void Info(string message, params object[] args)
        {
            LogMessage(string.Format(message, args), LogLevel.Info);
        }

        private void LogMessage(string message, LogLevel level)
        {
            if (IsInitialized)
            {
                var log = GenerateLog(message, level);
                WriteToFile(log);
            }
        }

        private void WriteToFile(string text)
        {
            using (StreamWriter sw = File.AppendText(CompletePath))
            {
                sw.WriteLine(text);                
            }
        }

        private string GenerateLog(string message, LogLevel level)
        {
            return string.Format("[{0}] Level={1} {2}", DateTime.Now, level.GetDescription(), message);
        }

        private string ExtractExceptionMessage(Exception ex)
        {
            return string.Format("Exception Message={0}; StackTrace={1}", ex.Message, ex.StackTrace);
        }
    }
}
