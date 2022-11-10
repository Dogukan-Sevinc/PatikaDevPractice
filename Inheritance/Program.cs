using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        //              Canlılar
        //                  |
        //      Bitkiler            Hayvanlar
        //  |             |       |            |
        // Tohumlu  Tohumsuz   Surungenler  Kuslar+

        TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();

         // Gidip miras alınan yerde methodu public'ten protected'a çevirdik. Biz bu FotosentezYapmak(); methodunu
         // kullanmak istiyoruz. Gideceğiz tohumlu bitkilere constructer varsayılan yapıcı methodunu yapacağız.
         // YANİ: 

         //   public TohumluBitkiler(){
         //     base.FotosentezYapmak();
         //     }

        tohumluBitkiler.TohumlaCogalma();

        Console.WriteLine("*************");

        Kuslar martı = new Kuslar();

        // Erişemediğim için sildim, çünkü Adaptasyon protected oldu. martı.Adaptasyon();
        martı.Ucmak();

        }
    }


    
}