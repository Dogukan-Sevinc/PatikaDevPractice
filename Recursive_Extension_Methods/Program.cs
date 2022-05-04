using System;

namespace Recursive_Extension_Methods // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yineleme
            //3*4 = 3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result*3;
                Console.WriteLine(result);
            }
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar (Extension Class ve Methodlar static olmalı, static olmazsa bunlara erişemeyiz, nesnesi olmadan bunlara erişebilmeliyiz.)
            string ifade = "Zikriye Ürkmez Cengiz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());
                Console.WriteLine(ifade.MakeLowerCase());
            }

        }
    }

    public class Islemler{
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi,üs-1)*sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3;
        //Expo(3,2)*3*3;
        //Expo(3,1)*3*3*3;
        // 3*3*3*3 = 3^4;
    }

    public static class Extension
    {   //CheckSpaces methodunun içine this ifadesini eklersem bu artık bir Extension Method oluyor.
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
    }
}