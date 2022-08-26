using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne kadar saat çalıştınız?");
            int saat = int.Parse(Console.ReadLine());
            string kosul = saat == 0 ? "Bence çalışmaya başlamalısın" : (saat >= 1 && saat <= 3 ? "Biraz daha çalışırsan güzel yerlere varacaksın" : (saat >= 4 && saat <= 6 ? "Yeteri kadar çalıştın" : "Daha fazla çalışma, zarar göreceksin."));
            Console.WriteLine(kosul);
        }
    }
}
