using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,IloggerService ılogger
            )
        {
            //Başvuran bilgilerini Değerlendirme
            
            krediManager.Hesapla();
            ılogger.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
