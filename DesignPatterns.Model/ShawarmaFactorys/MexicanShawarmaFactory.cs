using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model.Products;
using DesignPatterns.Model.Products.Additives;
using DesignPatterns.Model.Products.Lavashs;
using DesignPatterns.Model.Products.Meats;
using DesignPatterns.Model.Products.Sauces;

namespace DesignPatterns.Model.ShawarmaFactorys
{
    public class MexicanShawarmaFactory : ShawarmaFactory
    {
        public override string CreateName()
        {
            return "Мексиканская шаверма";
        }

        public override Lavash CreateLavash()
        {
            return new CheeseLavash();
        }

        public override Meat CreateMeat()
        {
            return new PorkMeat();
        }

        public override Sauce CreateSauce()
        {
            return new TomatoSauce();
        }

        public override List<Product> CreateAdditives()
        {
            return [new Jalapeno(), new FrenchFries()];
        }
    }
}
