using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
   /*      Söz Dizimi
            class SinifAdi
            {
                property: [Erişim Belirleyici] [Veri Tipi] ozellikAdi;
                method:   [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdı(Parametre Listesi)
                {
                    //Metod Komutları
                    
                }
            }

            Erişim Belirleyicileri
            1. Public : Her yerden erişilebilir.
            2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            3. Internal : Sadece bulunduğu proje içerisinden erişilebilir
            4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.      
   */
            // Çalışan sınıfından bir "instance(örnek)" yaratacağız*********************
            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=23425634;
            calisan1.Departman="İnsan Kaynakları";  
            // Yukarıda çalışan 1 tanımlandı

            calisan1.CalisanBilgileri(); // Calışan 1'in bilgilerini ekrana yazdırıcak.

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri(); // Çalışan 2'nin bilgilerini ekrana yazdır




        }

        class Calisan
            {
                public string Ad;
                public string Soyad;
                public int No;
                public string Departman;
                public void CalisanBilgileri()
                {
                    Console.WriteLine("Çalışan Adı:{0}", Ad);
                    Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
                    Console.WriteLine("Çalışan Numarası:{0}", No);
                    Console.WriteLine("Çalışan Departmanı:{0}", Departman);
                }
            }
    }
}