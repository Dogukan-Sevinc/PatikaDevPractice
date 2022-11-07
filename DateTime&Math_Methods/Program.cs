using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Günü saatle getiriyor.
            Console.WriteLine(DateTime.Now.Date); //Tarih
            Console.WriteLine(DateTime.Now.Day); // Gün
            Console.WriteLine(DateTime.Now.Month); // Ay
            Console.WriteLine(DateTime.Now.Year); // Yıl
            Console.WriteLine(DateTime.Now.Hour); // Saat
            Console.WriteLine(DateTime.Now.Minute); // Dakika
            Console.WriteLine(DateTime.Now.Second); // Saniye

            Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın hangi günündeyim
            Console.WriteLine(DateTime.Now.DayOfYear); // Yılın kaçıncı günündeyim.
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // Saat formatında veriyor
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // Saniyesiz saat formatı

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DataTime Format - ToString'i formatlama için kullanıyoruz
            Console.WriteLine(DateTime.Now.ToString("dd")); // 24 - Sayıyla
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat - Günün Kısaltmasıyla
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday - Günün full ismi

            Console.WriteLine(DateTime.Now.ToString("MM")); // 04 - Sayıyla 
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr - Ayın kısaltmasıyla
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday - Ayın full ismi

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // Mutlak değer alır, 25
            Console.WriteLine(Math.Sin(90)); //
            Console.WriteLine(Math.Cos(90)); //
            Console.WriteLine(Math.Tan(90)); //

            Console.WriteLine(Math.Ceiling(22.3)); // Bir sonraki tam sayıya yuvarlar, 23
            Console.WriteLine(Math.Round(22.3)); // En yakın sayıya yuvarlar, 22
            Console.WriteLine(Math.Round(22.7)); // En yakın sayıysa yuvarlar, 23
            Console.WriteLine(Math.Floor(22.3)); // Aşağıya yuvarlar.

           Console.WriteLine(Math.Max(2,6));
           Console.WriteLine(Math.Min(2,6));

           Console.WriteLine(Math.Pow(3,4)); // 3^4ü verir, 81
           Console.WriteLine(Math.Sqrt(9)); // Karekökünü alır, 3
           Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logaritmik karşılığını verir.
           Console.WriteLine(Math.Exp(3)); // e üzeri 3, 20.0855.
           Console.WriteLine(Math.Log10(10)); // 10 sayısının 10 tabanındaki karşılığı , 1.
            

            




        }
    }
}