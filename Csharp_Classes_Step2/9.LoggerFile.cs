using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Classes_Step2
{
    static class LoggerFile
    {
        // Fields
        static string _logFilePath = "log.txt";
        static string _logFileDescription = "This file contains application logs.date:mar-2025";

        //properties
        static string LogFilePath { get; set; }

        static LoggerFile ()
        {
            LoggerFile.LogFilePath = _logFilePath;
            LoggerFile.LogFilePath = _logFileDescription;

        }

        static void LogMassage (string Leval, string Message)
        {
            Console.WriteLine($"{DateTime.Now} : {Leval} {Message} ");
        }
        static void InfoMessage (string Message)
        {
            LoggerFile.LogMassage("Info :", Message);
        }
        static void WornigMessage(string Message)
        {
            LoggerFile.LogMassage("Worning:", Message);
        }
        static void ErrorMessage(string Message)
        {
            LoggerFile.LogMassage("Error:", Message);
        }
        static void Main()
        {
            LoggerFile.InfoMessage("This is info message");
            LoggerFile.WornigMessage("This is worning message");
            LoggerFile.ErrorMessage("This is error message");

            Console.WriteLine($"Log File Path : {LoggerFile.LogFilePath}");
            Console.WriteLine($"Log File Description : {LoggerFile._logFileDescription}");
            Console.WriteLine("---------------------------------");

        }

    }
}
