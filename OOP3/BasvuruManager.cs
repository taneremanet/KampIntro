using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {


            // Başvuran bilgilerini değerlendirme

            //// Bu şekilde yaparsak tüm başvuruları konut kredisine bağımlı hale getiririz
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // Bağımlılıktan kurtardık
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            // Listedeki her bir kredinin hesabını yapar.
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
