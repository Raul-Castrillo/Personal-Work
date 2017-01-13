using Raul.Library.Logger.Levels;
using System;
using System.Collections.Generic;

namespace Raul.Library.Logger
{
    public class Logger : ILogger
    {
        private static readonly ILogger LoggerInstance = new Logger();
        private static string CompletePath;
        private static bool IsInitialized;

        public static ILogger Instance
        {
            get { return LoggerInstance; }
        }

        public void Initialize(string path, string fileName)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
            
            //TODO
            // check path exist, create file, blabla
            // if succsess IsInitialized=true
        }

        public void Error(string message)
        {
            if (IsInitialized)
            {
                //TODO wrtie to file
            }
        }

        public void Error(string message, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, Exception ex)
        {
            throw new NotImplementedException();
        }

        private void WriteToFile(string text)
        {

        }

        private string GenerateLog(string message, LevelType level)
        {

        }
    }
}
