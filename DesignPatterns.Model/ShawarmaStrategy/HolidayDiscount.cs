using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaStrategy
{
    public class HolidayDiscount : IDiscount
    {
        double IDiscount.Discount(Shawarma shawarma)
        {
            return shawarma.Lavash.GetPrice() + shawarma.Meat.GetPrice() + shawarma.Sauce.GetPrice() + shawarma.Additives.Sum();
        }
    }
}
