using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sınıfların içermesi gereken methodların imzalarının yer aldığı, özelliklerin tanımlandığı bir taslak.
            // Interface içersindeki propertylere değer ataması yapılmaz, methodların gövdesi de yazılmaz
            // Interface neden ihtiyaç duyarız? => Aynı işi kendi tarzında yapmasını sağlar sınıfların

            // FileLogger aslında bir class. New anahtar kelimesiyle onun "instance"'ı yani nesnesini oluşturuyorum

            FileLoger fileLoger = new FileLoger();
            fileLoger.WriteLog();

            DataBaseLogger dataBaseLogger = new DataBaseLogger();
            dataBaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLoger());
            logManager.WriteLog();
        }
    }
}