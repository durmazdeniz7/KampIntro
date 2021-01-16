using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do Not Repeat yourself-Kendini tekrarlama
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 940000000;

            double faizOrani = 1.45;
            bool sistemeGirmisMi = true;


            

            if (sistemeGirmisMi == true)
            {
                Console.WriteLine("Sisteme Giriş Yapıldı ");

            }
            else
            {
                Console.WriteLine("Sisteme Giriş YAPILMAMIŞ");
            }




            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);







        }
    }
}
