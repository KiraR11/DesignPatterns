using DesignPatterns.Model.Products.Additives;
using DesignPatterns.Model.Products.Lavashs;
using DesignPatterns.Model.Products.Meats;
using DesignPatterns.Model.Products.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaStrategy
{
    public class HomelessCost : ICost
    {
        double ICost.Cost(Shawarma shawarma)
        {
            return (shawarma.Meat.GetPrice() + shawarma.Sauce.GetPrice() + shawarma.Additives.Sum()) * 0.3;
        }
    }
}
