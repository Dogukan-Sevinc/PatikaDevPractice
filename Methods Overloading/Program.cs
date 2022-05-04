using System;

namespace Methods // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }   
            else {
                Console.WriteLine("Başarısız!");
            }
        }
    }
}