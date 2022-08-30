using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Yavuz", "Engin", "Murat","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //New demek yeni referans adresi demek.
            //Yukarıda Array oluşturduk ardından new diyip 5 elemanlı olarak bu Array'in referans değerini yeniledik. Bu Array artık
            //ilk halindeki değerleri taşımıyor. Çünkü yeni bir referans değeri oldu belllekte. 4. Elemanı da boş olduğundan sonradan
            //Değiştirebildik ve Array'deki tek değer İlker oldu. Normalde Array'lere eklenemez, değiştirilemez..

            List<string> isimler2 = new List<string> {"Yavuz","Engin","Murat","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
