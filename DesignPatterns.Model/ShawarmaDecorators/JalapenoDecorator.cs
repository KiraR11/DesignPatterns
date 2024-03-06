using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model.Products.Additives;

namespace DesignPatterns.Model.ShawarmaDecorators
{
    public class JalapenoDecorator : ShawarmaDecorator
    {
        public JalapenoDecorator(Shawarma shawarma) : base(shawarma)
        {
            Shawarma.Additives.Add(new Jalapeno());
        }
        public override TimeOnly GetCookingTime()
        {
            return Shawarma.GetCookingTime().AddMinutes(0.05);
        }
    }
}
