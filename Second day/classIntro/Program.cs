namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adı = "ahmet ";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.KursEğitmeni = "E.D.";
            kurs1.izlenmeOranı = 68;
            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "java";
            kurs2.KursEğitmeni = "A.S.A.";
            kurs2.izlenmeOranı = 64;
            
            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Html";
            kurs3.KursEğitmeni = "E.D.K.";
            kurs3.izlenmeOranı = 52;

            //Console.WriteLine(kurs1.KursAdı+" : "+kurs1.KursEğitmeni);
            //Console.WriteLine(kurs2.KursAdı + " : " + kurs2.KursEğitmeni);
            //Console.WriteLine(kurs3.KursAdı + " : " + kurs3.KursEğitmeni);
            //bunları yapmak yerine : 
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı+" : "+ kurs.KursEğitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }

        public string KursEğitmeni { get; set; }

        public int izlenmeOranı { get; set; }

    }
}