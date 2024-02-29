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
            Additives.Add(new FrenchFries());
        }
    }
}
