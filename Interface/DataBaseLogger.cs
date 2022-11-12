using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class DataBaseLogger : Ilogger
    {
        public void WriteLog()
        {
           Console.WriteLine("Database'e yazar");
        }
    }
}