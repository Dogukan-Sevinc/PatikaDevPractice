using System;

namespace Encapsulation
{
    class Program
    {       /*  // Encapsulation
            Bir nesnenin bazı özelliklerini, işlevlerini diğer classlardan korumak anlamına geliyor. Biz bu korumayı
        erişim belirleyicileriyle yapıyoruz.[Private-Public-Internal-Protected]. Bir class'ı korumak istiyorsak, yani
        dışardan erişilmez yapmak istiyorsak "Private" olarak tanımlamalıyız.

            Bazı koşullarda açmak istiyorsak; Encapsulation kavramı ortaya çıkıyor. Property'ler yardımıyla 
        Encapsulation'ı kullanarak biz sınıfın üyelerini/fieldlarını kapayabiliriz. Onların değişimini engelleyebiliriz
        ya da koruyabiliriz. Dolayısıyla bunun için propertyleri kullanıyoruz. 

            Propertyler {get; set;} lerden oluşur: 
            GET: Property'in private değerini "Getiren" eden, SET: Property'in private değerini "Değiştiren" eden
    */
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Doğukan";
            ogrenci.Soyad = "Sevinç";
            ogrenci.OgrenciNo = 12345;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int sinif;

        public string Ad
        {
            get => ad; //get {return ad;}
            set => ad = value; //set{ ad = value;}
        }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sinif En Az 1 Olmalı!");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci()
        {

        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**** Ogrenci Bilgileri ****");
            Console.WriteLine("Ogrenci Adi     : {0}", this.Ad);
            Console.WriteLine("Ogrenci Soyadi     : {0}", this.Soyad);
            Console.WriteLine("Ogrenci Ogrenci No     : {0}", this.OgrenciNo);
            Console.WriteLine("Ogrenci Sinifi     : {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }

    }
}