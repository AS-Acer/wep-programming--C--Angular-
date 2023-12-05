using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    public class sepetManager
    {
        public void Ekle(product urun)
        {
            Console.WriteLine("Tebrikler. '"+ urun.Ad+"' ürünü sepete eklendi ! ");
        }
        public void EkleManual(int UrunId,string UrunAdı,int UrunFiyatı,string UrunAcıklaması,int StokAdedi)
        {
            Console.WriteLine(UrunId + ". ürün (Yeni)");
            Console.WriteLine("Ürün adı : " + UrunAdı);
            Console.WriteLine("Ürün fiyatı : " + UrunFiyatı);
            Console.WriteLine("Ürün açıklaması : " + UrunAcıklaması);
            Console.WriteLine("Stok adedi : "+StokAdedi);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
