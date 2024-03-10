using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaStrategy
{
    public class BirthdayDiscount : ICost
    {
        double ICost.Cost(Shawarma shawarma)
        {
            double cost = shawarma.Lavash.GetPrice() + shawarma.Meat.GetPrice() + shawarma.Sauce.GetPrice() + shawarma.Additives.Sum();
            double discount = 70;
            cost = cost > discount ? cost - discount : cost;
            return cost;
        }
    }
}
