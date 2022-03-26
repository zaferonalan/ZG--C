using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

        }
    }
}
