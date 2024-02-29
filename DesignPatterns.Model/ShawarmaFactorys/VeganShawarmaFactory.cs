using DesignPatterns.Model.Products;
using DesignPatterns.Model.Products.Additives;
using DesignPatterns.Model.Products.Lavashs;
using DesignPatterns.Model.Products.Meats;
using DesignPatterns.Model.Products.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaFactorys
{
    public class VeganShawarmaFactory : ShawarmaFactory
    {
        public override string CreateName()
        {
            return "Вегатерианская шаверма";
        }

        public override Lavash CreateLavash()
        {
            return new ClassicLavash();
        }

        public override Meat CreateMeat()
        {
            return new SoyMeat();
        }

        public override Sauce CreateSauce()
        {
            return new TomatoSauce();
        }

        public override List<Product> CreateAdditives()
        {
            return [new FrenchFries()];
        }
    }
}
