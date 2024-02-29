using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model.Products.Additives;

namespace DesignPatterns.Model.ShawarmaDecorators
{
    public class CheeseDecorator : ShawarmaDecorator
    {
        public CheeseDecorator(Shawarma shawarma) : base(shawarma)
        {
            Additives.Add(new Cheese());
        }
    }
}
