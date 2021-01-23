using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService loggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            // interface'leri birbirinin alternatifi olan fakat kod içeriği farklı
            // durumlar için kullanırız.

            List<IKrediManager> krediler = new List<IKrediManager>() 
            {
                ihtiyacKrediManager,
                tasitKrediManager            
            };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
