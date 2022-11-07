using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Avantaj-Dezavantajı
        /*      + Hızlıdır.
                + Fifo mantığı ile çalışır. 
                + Veriler sıralı olduğu için veriye erişmek kolaydır.
                - Array'in elemanları aynı veri tipinden olmalıdır.
                - Array'in boyutu önceden belirlenmelidir.

            // Koleksiyon Avantajları-Dezavantajları
                + Bazı koleksiyon tipleri, Ram yettiği sürece genişleyenbilir ve farklı türde veri tipini saklayabilir.
                + Koleksiyonların veri tipi object(nesne) olduğu için her türlü veriyi saklayabiliriz.
                
                Not: Koleksiyonlar veriyi object tipind tutuyor demiştik. Object de bir referans tipi yani heapte tutuluyor. Bu demek oluyor ki değer tipinde (int, char, bool, enum vs.) bir veriyi koleksiyona eklemek için "boxing" işlemi yapıyorum. Daha sonra elemanı okumak için "unboxing" işlemi yapıyorum. 

                - Boxing ve unboxing işlemi pc için maliyetli bir işlem, dolayısıyla performansı olumsuz etkiliyor.

            // Generic List
                Generic list bir list sınıfı koleksiyonudur. Generic List bir list sınıfı tanımlarken T olarak bir tip değişkeni alır. Generic olmasını sağlayan da bu T veri tipidir. T, listenin hangi türden veri tutacağını belirler. Bu tanımlama sonunda farklı türden bir veri tipini generic list ile saklayamazsınız.

                Örnek söz dizimi;
                    List<string> renkler = new List<string>();

                    renkler.Add("Mavi");
                    renkler.Add("Kırmızı");
        */

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count, Kaç tane eleman var onu öğrenmek istiyorum?

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve List.ForEach ile Elemanlara Erişim
            // Not: Foreach, collectionların elemanları üzerinde işlem yapmak için kullanabiliriz.

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }


            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi)); // ********** Bu da alternatif foreach yazımı
            renkListesi.ForEach(renk=> Console.WriteLine(renk)); // MVC'de kullandığım projelerdeki yapı

            // Listeden Eleman Çıkarma : Remove
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            // Liste İçerisinde Arama : Contains
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içinde bulundu!");
            }

            // Eleman ile İndex'e Erişme : BinarySearch
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            // Dizi'yi List'e Çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>();

            // Listeyi Temizleme : Clear
            hayvanListesi.Clear();

            // List İçerisinde Liste Tutmak

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            // Bu listeye eleman atıyor olmamız lazım örneği yapabilmek için. Bu yüzdende Kullanıcılar sınıfının nesnelerine ihtiyacımız var. Hadi nesnelerini oluşturalım:

            //Altta Encapsule olduğu için kullanıcılar class'ında private yaptığımız küçük isim'e (isim) eişemiyor
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim="Ayşe";
            kullanıcı1.Soyisim="Yılaz";
            kullanıcı1.Yas=26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim="Özcan";
            kullanıcı2.Soyisim="Çalışkan";          // 3 property'i isim, soyisim, yaş
            kullanıcı2.Yas=26;


            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            Console.WriteLine(kullanıcıListesi.Count);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas=24
            });

            yeniListe.Add(new Kullanıcılar(){
                Isim="Mustafa",
                Soyisim="Yılmaz",
                Yas=29
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yas:" + kullanıcı.Yas);
            }

             foreach (var kullanıcı in yeniListe)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yas:" + kullanıcı.Yas);
            }

            yeniListe.Clear();

        }
    }

    public class Kullanıcılar
    {      
         // Aşağıyı erişim belirtiyicilerini kullanarak(private) encapsule edicez.
            private string isim;
            private string soyisim;
            private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

        // Private ile erişimi engelliyoruz. İstersek get'i istersek set'i dışarı kapatabiliriz. Burada da encapsule etmiş oluyoruz. 



    }

        
}