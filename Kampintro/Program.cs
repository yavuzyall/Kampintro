using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {   
            //type safety = tip güvenliği...
            //DO NOT REPEAT YOURSELF = Kendini tekrarlama!!!

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış resmi");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış resmi");
            }
            else
            {
                Console.WriteLine("Değişmedi resmi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
