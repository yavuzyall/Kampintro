using System;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;

            while (true)
            {
                Console.WriteLine("Lütfen sayı giriniz = ");
                int degisken = int.Parse(Console.ReadLine());
                if (degisken % 2 == 0)
                {
                    sayi = sayi + degisken;
                }
                else
                {
                    sayi = sayi - degisken;
                }
                if (sayi == 0)
                {
                    break;
                }
                Console.WriteLine("Son sayı = "+ sayi);

            }
        }
    }
}
