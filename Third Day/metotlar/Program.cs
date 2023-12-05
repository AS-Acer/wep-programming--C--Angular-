using metotlar;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            product urun1 = new product(); 
            urun1.Id = 1;   
            urun1.Ad = "Elma";
            urun1.fiyat = 9.5;
            urun1.acıklama = "Amasya ELması";
            urun1.stokAdedi = 250;

            product urun2= new product();
            urun2.Id = 2;
            urun2.Ad = "Karpuz";
            urun2.fiyat = 49.90;
            urun2.acıklama = "Diyarbakır Karpuzu";
            urun2.stokAdedi = 100;

          
            product[] urunler = new product[] {urun1,urun2 };

            foreach ( product donenUrunler in urunler) 
            {
                Console.WriteLine(donenUrunler.Id+". ürün");
                Console.WriteLine("Ürün adı : "+donenUrunler.Ad);
                Console.WriteLine("Ürün fiyatı : " + donenUrunler.fiyat);
                Console.WriteLine("Ürün açıklaması : " + donenUrunler.acıklama);
                Console.WriteLine("Stok adedi : "+ donenUrunler.stokAdedi);
                Console.WriteLine("-----------------------------------------------");

            }

            Console.WriteLine("-----------------Metodlar : -------------------");

            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);//farklı sayfada çalıştırma denemesi
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" Manuel eklenen ürün : ");
            sepetManager.EkleManual(3, "Kavun", 35, "Güzel kavun",100);
        }
    }
}

