using System;

namespace VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte veri1 = 254; //1 ile 255 arası değer alır.
            sbyte veri2 = -100; // -128 ile 127 arası değer alır.
            short veri3 = 31000; // Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.
            ushort veri4 = 65534; //Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.
            int veri5 = 2147483647; //Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.
            uint veri6 = 4294967294; //Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.
            long veri7 = 2132312312334; //Uzunluğu 8 byte’tır, -10 üzeri 20 ile 10 üzeri 20 arasında değer alır.
            ulong veri8 = 5454453544;
            float veri9 = 37;
            double veri10 = 21.3;
            decimal veri11 = 23134;
            char veri12 = 'A'; //Uzunluğu 2 byte’tır, Bütün ınicode karakterleri kapsar.
            string veri13 = "Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.";
            bool veri14 = true; //True – false değer tutan tiptir.

            int[] integerlar = new int[] {veri1, veri2, veri3, veri4, veri5};
            ulong[] uzunlar = new ulong[] {veri6,veri8 };
            foreach (var item in integerlar)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < uzunlar.Length; i++)
            {
                Console.WriteLine(uzunlar[i]);
            }



        }
    }
}
