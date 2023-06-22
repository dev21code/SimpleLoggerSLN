using System;

namespace SimpleLogger
{
    public class SimpleLogger
    {
        public string LogFilePath { get; set; }

        public enum Severity
        {
            VeryLow,
            Low,
            Medium,
            High,
            ExtremelyHigh
        }

        public bool WriteToLog(DateTime eventTime, string description, Severity severitylevel)
        {
            try
            {
                var logResults = $"{DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")}, {description}, {severitylevel}";



                return false;


            }
            catch
            {
                return false;
            }
        }
    }
}
