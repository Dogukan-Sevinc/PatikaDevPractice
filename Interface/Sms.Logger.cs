using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class SmsLogger : Ilogger
    {
        public void WriteLog()
        {
            //  throw new NotImplementedException();
            Console.WriteLine("Sms olarak yazar");
        }
    }
}