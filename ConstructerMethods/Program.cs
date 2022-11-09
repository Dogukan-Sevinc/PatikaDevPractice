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
            Calisan calisan1 = new Calisan("Ayşe","Kara",23425634,"insan ");
 
            // Yukarıda çalışan 1 tanımlandı

            calisan1.CalisanBilgileri(); // Calışan 1'in bilgilerini ekrana yazdırıcak.

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri(); // Çalışan 2'nin bilgilerini ekrana yazdır

           Console.WriteLine("***** Çalışan 3 *****");
           Calisan calisan3 = new Calisan("Zikriye", "ürkmez");
           calisan3.CalisanBilgileri(); 

           Calisan calisan4 = new Calisan("Muzaffer", "Kuşan");
           calisan4.CalisanBilgileri();

        }

       

        class Calisan
            {
                public string Ad;
                public string Soyad;
                public int No;
                public string Departman;

                // Constructer
    /*              Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan yapıcı metotlara
                kurucu ya da constructer denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu
                metodlar içerisinde yaparız.
                    1) Public olmalı.
                    2) Geri dönüş değerleri yoktur.
                    3) Yapıcı metodların isimleri sınıf isimleri ile aynı olmalıdır.
                
                    Kurucu metodların imzasını değiştirerek overload edebiliriz.

    */            
                // Kurucu Method örneği;

                public Calisan(string ad, string soyad, int no, string departman)
                {
                    this.Ad = ad;
                    this.Soyad = soyad;
                    this.No = no;
                    this.Departman = departman;
                }

                public Calisan(string ad, string soyad)
                {
                    this.Ad = ad;
                    this.Soyad = soyad;
                }
                 public Calisan(){}

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