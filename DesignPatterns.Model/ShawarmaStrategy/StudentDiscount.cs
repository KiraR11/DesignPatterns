using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaStrategy
{
    public class StudentDiscount : IDiscount
    {
        double IDiscount.Discount(Shawarma shawarma)
        {
            return shawarma.Lavash.GetPrice() + shawarma.Sauce.GetPrice() + shawarma.Additives.Sum();
        }
    }
}
