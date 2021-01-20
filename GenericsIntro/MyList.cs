using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; // dizi

        // constructor method (yapıcı metot)
        public MyList()
        {
            items = new T[0]; // baslangicta hic elemani olmayan bir dizi olusturulur
        }

        public void Add(T item)
        {
            // baslangicta items.Length = 0, sonra 1, sonra 2 seklinde birer birer artar
            // fakat her new yaptigimizda referans numaralarini kaybederiz, 
            // bu yuzden referans numaralarini gecici dizide tutturmamiz lazim
            T[] tempArray = items;         // gecici dizi
            items = new T[items.Length + 1]; // kapasitesi artmis yeni dizi
            for (int i = 0; i < tempArray.Length; i++)
            {
                // gecici dizideki her eleman, yeni genisletilmis diziye aktarilir
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; // fazlalik bir kapasite item parametresi ile doldurulur
        }

        // dizinin uzunlugunu elde etmek icin
        public int Length
        {
            get { return items.Length; }
        }

        // for dongusu ile dizinin elemanlarini elde etmek icin
        public T[] Items
        {
            get { return items; }
        }
    }
}
