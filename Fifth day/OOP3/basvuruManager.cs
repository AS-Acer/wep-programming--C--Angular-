using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class basvuruManager
    {
        //Method injection
       public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //üst sınıfı parametre olarak vererek duruma göre bütün kredi seçeneklerini kullanabileceğimiz bir metod yazdık
            
            krediManager.Hesapla();
            //hesapladıktan sonra hangi servis kullanıldığını logla dedik
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //listenin her bir elemanını hesapladık
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
