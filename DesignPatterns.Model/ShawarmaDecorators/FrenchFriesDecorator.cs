using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model.Products.Additives;

namespace DesignPatterns.Model.ShawarmaDecorators
{
    public class FrenchFriesDecorator : ShawarmaDecorator
    {
        public FrenchFriesDecorator(Shawarma shawarma) : base(shawarma)
        {
            Shawarma.Additives.Add(new FrenchFries());
        }
        public override TimeOnly GetCookingTime()
        {
            return Shawarma.GetCookingTime().AddMinutes(0.1);
        }
    }
}
