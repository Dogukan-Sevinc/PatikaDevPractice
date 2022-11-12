using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class FileLoger : Ilogger
    {
        public void WriteLog()
        {
           Console.WriteLine("Dosyaya log yazar");
        }
    }
}