using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ahmet", "Said", "Engin","Demirog" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);//boş değer olacak çünkü bellekte yeni isimler adında 5 elemanlı bir liste oluşturduk bu listenin 4 elemanı boş sadece ilker var


            List<string> isimler2 = new List<string> { "Ahmet", "Said", "Engin", "Demirog" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2.Count);//içinde değer olan eleman sayısı
            Console.WriteLine(isimler2.Capacity);//taşıyabileceği eleman sayısı



        }
    }
}