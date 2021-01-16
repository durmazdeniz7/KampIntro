using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        //Naming convencition
        public void Ekle(Urün urün)


        {


            Console.WriteLine("Sepete Eklendi " +urün.Adi);
            


        }



        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi) {

            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }

    }
}
