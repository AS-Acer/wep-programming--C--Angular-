using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C kampı";
            string kurs2 = "python kampı";
            string kurs3 = "java kampı";
            string kurs4 = "css kampı";

            //yeni bir string array atadık
            string[] kurslar = new string[] {kurs1,kurs2,kurs3,kurs4};

            Console.WriteLine("for döngüsü : ");

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("foreach kısmı : ");

            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu -- footer ");
        }
    }
}