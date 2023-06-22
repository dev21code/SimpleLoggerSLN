using System;

namespace SimpleLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerObj = new SimpleLogger { LogFilePath = @"c:\\" };
            loggerObj.WriteToLog(DateTime.Now, "This is a sample", SimpleLogger.Severity.Low);
        }
    }
}
