// See https://aka.ms/new-console-template for more information
using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = 0;
musteri1.Adi = "Ahmet";
musteri1.Soyadi = "Acer";
musteri1.TcNo = "68418413543";



TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = 15616;
musteri2.SirketAdi = "Acer Company";
musteri2.VergiNo = "1256131";

//üst sınıf referansı kullanarak yeni alt sınıf için bellekte yeni yer oluşturduk thanks to inheritance
Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriYonetimi manager1 = new MusteriYonetimi();
manager1.Add(musteri1);
manager1.Add(musteri2);

