using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;

            //sayı1  30 olur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayılar1[0]= 999 olur


            // değer tip: int, decimal, fload, double, bool (sayısal değerler)
            // referans tip : array, class, interface 

            //stack: değer tip olanlar burda gerçekleşir değişkenlerin değerleri aktarlılır ve irtibatı kopartır
            
            //heap:değerlerin bellekteki yeri\adresi olarak atanır yani adres değişikliği yapmış oluruz
            //adres değişimi sonucu adressiz kalan değerler bellekteki çöp kısmına atılır 
        }
    }
}