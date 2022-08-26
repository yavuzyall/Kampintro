using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string renk = Console.ReadLine();
            switch (renk)
            {
                case "kırmızı": 
                    Console.WriteLine("Lütfen durunuz."); 
                    break;
                case "sarı":
                    Console.WriteLine("Lütfen hazır olunuz.");
                    break;
                default:
                    Console.WriteLine("Lütfen geçiniz...");
                    break;
            }
        }
    }
}
