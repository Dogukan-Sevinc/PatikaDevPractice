using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class LogManager: Ilogger
    {
        public Ilogger _logger; // Logger sınıfının bir instance'ı yarattık.

        public LogManager(Ilogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}