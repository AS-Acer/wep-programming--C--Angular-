using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>//mylistimde t ile çalışacağım(tür olarak, bilinmeyen yerine x demekle aynı)
    {
        T[] items;

        public MyList()//ctor yapıcı metod
        {
            items = new T[0];//yeni array oluşturduk
        }

        public void Add(T item)
        {
            T[] tempArray = items;//geçici diziye elemanları ekliyoruz ki yeni liste oluşunca önceki değerler kaybolmasın 
            items = new T[items.Length + 1];//dizinin eleman sayısını bir arttırdım
            for (int i = 0; i < items.Length; i++) 
            {
                items[i] = tempArray[i]; //geçici verdğim değerleri geri alıyorum 
            }
            items[items.Length - 1] = item;//asıl eklemek istediğim yeni elemanı son değer boşluğuna ekliyorum
        }
    }
}
