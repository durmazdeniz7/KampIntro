using System;

namespace dongüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string []{ "Yazılım Geliştirici  Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs","Java","Python","12100","C++","C#"};
           
            /*
            string kurs1 = "Yazılım Geliştirici  Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            */


            //foreach (var dizi in kurslar)
            //{
            //    Console.WriteLine(dizi);
            //}
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //for (int i = 1; i < 10; i+=2)
            //{
            //    Console.WriteLine(i);

            //}

            Console.WriteLine("for bitti");
            Console.WriteLine();

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("Sayfa Sonu");
        }
    }
}
