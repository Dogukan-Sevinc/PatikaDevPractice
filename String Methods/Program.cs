using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz!"; // 29
            string degisken2 = "CSharp";

            //Length : Karakter yazdırmamızı saglar.
            Console.WriteLine(degisken.Length);

            string melisa = "melisa";  //6
            string melisa2="melisa melisa"; //13, Bosluk dahil sayıyor her bir birimi

            Console.WriteLine(melisa.Length);
            Console.WriteLine(melisa2.Length);

            //ToUpper, ToLower 
            Console.WriteLine(degisken.ToUpper()); // Bütün harfleri büyüttü
            Console.WriteLine(degisken.ToLower()); // Bütün harfleri küçülttü

            //Concat
            Console.WriteLine(String.Concat(degisken, "Merhaba!")); // String ifadenin sonuna yazı eklenmesini sağlıyor

            //Compare, (-1,0,1)
            //CompareTo=> // 1. degisken 2. degiskene eşitse 0, 1. degisken 2. degiskenden az sayısı var ise -1, 1.degisken 2.degiskenden fazla sayısı varsa 1 döndürür. (-1,0,1)
            Console.WriteLine(degisken.CompareTo(degisken2)); 
            Console.WriteLine(string.Compare(degisken,degisken2,true)); //true'yu kullanırsan büyük/küçük harf duyarsız.
            Console.WriteLine(string.Compare(degisken,degisken2,false)); //false kullanırsan büyük/küçük harf duyarlıdır.

            //Contains
            Console.WriteLine(degisken.Contains(degisken2)); // degisken 1'in içerisinde degisken 2 var ise true döner.
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); // Bitiyor mu sorusunu arıyoruz.
            Console.WriteLine(degisken.StartsWith("Merhaba!")); // Başlıyor mu sorusunu arıyoruz.

            //Index Of
            Console.WriteLine(degisken.IndexOf("CS")); // Kaçıncı indexte başladığını gösteriyor.
            Console.WriteLine(degisken.IndexOf("Zikriye")); // Bir şey bulamazsa -1 döner.
            Console.WriteLine(degisken.LastIndexOf("i")); // İfade edilen stringin son olarak nerede kullanıldığı

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! ")); //0. index'e ifade eklememizi sağlar.

            //PadLeft, PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30)); // 30'a tamamlayacak kadar boşluk ekletiyor
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); // Yıldız ekletiyor
            Console.WriteLine(degisken.PadRight(50)+degisken2); // 50'ye tamamlayacak kadar boşluk ekledi.
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);// Çizgi ekliyor

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10. karakterden sonrasını siler
            Console.WriteLine(degisken.Remove(5,3)); // 5'den itibaren 3 karakter sildi **********KULLANILIYOR.
            Console.WriteLine(degisken.Remove(0,1)); // Baştan ilk karakteri silmek.

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#")); // CSharp yazan yeri C# çevirdi.
            Console.WriteLine(degisken.Replace(" ", "*")); // Boşlukları( ), yıldıza(*) çevirdi.

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); 

            //Substring
            Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayıp sonuna kadar getirdi.
            Console.WriteLine(degisken.Substring(4,6)); // 4. indexten başlayıp 6 karakter getirdi.

            
            



            




            
        }
    }
}