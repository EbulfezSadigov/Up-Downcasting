using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updowncast
{
    class Currency
    {
        public class USD
        {
            public double Amount { get; set; }
            public USD(double Amount)
            {
                this.Amount = Amount;
            }
            public static implicit operator USD(AZN azn)
            {
                return new USD(azn.Amount / 1.7);
            }
            public static bool operator >(USD u, AZN a)
            {
                return u.Amount > (a.Amount * 1.69);
            }
            public static bool operator <(USD u, AZN a)
            {
                return u.Amount < (a.Amount / 1.69);
            }

        }

        public class AZN
        {
            public double Amount { get; set; }
            public AZN(double Amount)
            {
                this.Amount = Amount;
            }

            public static bool operator >(AZN a, USD u)
            {
                return a.Amount > (u.Amount * 1.7);
            }
            public static bool operator <(AZN a, USD u)
            {
                return a.Amount < (u.Amount * 1.7);
            }
            public static implicit operator AZN(USD usd)
            {
                return new AZN(usd.Amount * 1.7);
            }
        }

        public class EUR
        {
            public double Amount { get; set; }
            public EUR(double amount)
            {
                Amount = amount;
            }
            public static bool operator >(EUR e, AZN a)
            {
                return e.Amount > (a.Amount / 1.86);
            }
            public static bool operator <(EUR e, AZN a)
            {
                return e.Amount < (a.Amount * 1.86);
            }
            public static implicit operator EUR(AZN azn)
            {
                return new EUR(azn.Amount * 1.86);
            }
        }
    }
}
