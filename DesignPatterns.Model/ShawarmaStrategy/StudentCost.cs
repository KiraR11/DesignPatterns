using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaStrategy
{
    public class StudentCost : ICost
    {
        public double Cost(Shawarma shawarma)
        {
            return shawarma.Lavash.GetPrice() + shawarma.Sauce.GetPrice() + shawarma.Additives.Sum();
        }
    }
}
