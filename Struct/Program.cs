using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diktdortgen diktdortgen = new Diktdortgen();
            diktdortgen.KisaKenar = 3;
            diktdortgen.UzunKenar = 4;
            
            Console.WriteLine("Class Alan Hesabı: {0}",diktdortgen.AlanHesapla());

            Diktdortgen_Struct diktdortgen_Struct = new Diktdortgen_Struct();
            diktdortgen_Struct.KisaKenar = 3;
            diktdortgen_Struct.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı: {0}", diktdortgen_Struct.AlanHesapla());

        }

        class Diktdortgen
        {
            public int KisaKenar;
            public int UzunKenar;
            public long AlanHesapla()
            {
                return this.KisaKenar*this.UzunKenar;
            }
        }
        /*  Neden struct'ları kullanmalıyım neden class'ları kullanmalıyım ? 
            + Struct'ların avantajı stackte tutulduğu için hız sağlıyor.

            NOT: Uzmanlar söyler ki: 16 byte'a kadar olan veriler için sturct kullanın, 16 byte'dan fazla veriler
            için class kullanıyor olmak(referans tipinin gücünü kullanıyor olmak) avantaj.
            

        */

        struct Diktdortgen_Struct
        {
            public int KisaKenar;
            public int UzunKenar;
            public long AlanHesapla()
            {
                return this.KisaKenar*this.UzunKenar;
            }
        }
    }
}