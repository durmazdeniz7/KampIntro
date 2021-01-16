using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           


            string[] meyveler = new string[] { };

            Urün urün = new Urün();
            urün.Adi = "Elma";

            urün.Fiyati = 15;
            urün.Aciklama = "Amasya Elması";


            Urün urün1 = new Urün();
            urün1.Adi = "Karpuz";
            urün1.Fiyati = 80;
            urün1.Aciklama = "Diyarbakır";

            Urün[] urunler = new Urün[] { urün1, urün };


            foreach (Urün manav in urunler)
            {
                Console.WriteLine(manav.Adi);
                Console.WriteLine(manav.Fiyati);
                Console.WriteLine(manav.Aciklama);
                Console.WriteLine("-----------------------");



                Console.WriteLine("-----------------Metotlar---------------------");

                



            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urün);
            sepetManager.Ekle(urün1);
            sepetManager.Ekle2("Armut","Yeşil armut",12,10);
            sepetManager.Ekle2("Elma","Yeşil Elma",12,18);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu",155,545);


        }
    }
}


//Clean Code

