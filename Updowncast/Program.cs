using System;
using static Updowncast.Currency;

namespace Updowncast
{
    class Program
    {
        static void Main(string[] args)
        {
            EUR e = new EUR(300);
            AZN a = new AZN(500);
            Console.WriteLine(e > a);

            AZN azn = e;
            Console.WriteLine(e.Amount);
        }
    }
}
