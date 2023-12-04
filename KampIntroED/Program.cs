using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği :yanlış türe yanlış değişken
            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 3200;
            double faizOranı = 1.45;
            bool sistemGirisOk = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (sistemGirisOk = true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonnu");
            }



            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butponu");
            }
            else if(dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");
                    
            }else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();


             
            



        }
    }
}
