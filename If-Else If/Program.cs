using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
                if(time>=6 && time<11)
                    System.Console.WriteLine("Günaydın!");
                else if (time<=18)
                    System.Console.WriteLine("İyi Günler!");
                else 
                    Console.WriteLine("İyi Geceler");

                string sonuc= time<=18 ? "İyi Günler" : "İyi Geceler";
                Console.WriteLine(sonuc);

                sonuc = time>=6 && time<11 ? "Günaydın!" : time<=18 ? "İyi Günler!" : "İyi Geceler!";
                Console.WriteLine(sonuc);

        }
    }
}