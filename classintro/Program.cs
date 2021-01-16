using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni= "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;
            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Flutter";
            kurs2.Egitmeni= "Deniz Durmaz";
            kurs2.IzlenmeOrani = 97; 
            
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmeni= "Hayati Bilmemne";
            kurs3.IzlenmeOrani = 89; 
            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni= "MURAT";
            kurs4.IzlenmeOrani = 100;


            // Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmeni+" ");

            Kurs[] kurslar = new Kurs[]
            {
              kurs1,kurs2,kurs3,kurs4
            };
            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi+" : "+item.Egitmeni );
            }

        } 



    }


    class Kurs
    {

        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }





    }


}





