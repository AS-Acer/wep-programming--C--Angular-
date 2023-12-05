using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(double sayı1,double sayı2)
        {
            double toplam = sayı1 + sayı2;
            Console.WriteLine("Sonuç : "+toplam);
        }

        public void cıkar(double buyukSayı, double kucukSayı)
        {
            double fark = buyukSayı - kucukSayı;
            Console.WriteLine("Sonuç : "+ fark);
        }

        public void bol(double sayı1, double sayı2)
        {
            double bolum = sayı1 / sayı2;
            Console.WriteLine("Sonuç : "+bolum);
        }

        public void carp(double sayı1, double sayı2)
        {
            double carpım = sayı1 * sayı2;
            Console.WriteLine("Sonuç : "+ carpım);
        }
    }
}
