// See https://aka.ms/new-console-template for more information
using OOP3;
using System.Collections.Generic;
//interfacelerde o interface'i implemente eden classın referans numarasını tutabiliyor

IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
//ıhtiyacKrediManager.Hesapla(); kredimanangera verdik bu vazifeyi

IKrediManager tasıtKrediManager = new TasıtKrediManager();
//tasıtKrediManager.Hesapla();

IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();


ILoggerService databaseLoggerService = new DatebaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

basvuruManager basvuruManager = new basvuruManager();
basvuruManager.BasvuruYap(ıhtiyacKrediManager,databaseLoggerService);
basvuruManager.BasvuruYap(tasıtKrediManager,fileLoggerService);
basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);



List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager, tasıtKrediManager,konutKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
