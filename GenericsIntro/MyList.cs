using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Ben MyListimde T ile çalışacağım. Bana bir Type ver ve ben aşağıyı ona göre yapılandırayım anlamına gelir. T yerine
        // X de yazabilirdim.
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) //T türünde bir eleman ver.  
        {
            T[] tempArray = items; //Geçiçi Array (Dizi)
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
