using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor bir methoddur
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T items)
        {
            T[] tempArray = items; // geçici dizinin referansı itemsin referansı
            items = new T[items.Lenght + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Lenght - 1] = items;
        }
    }
}
