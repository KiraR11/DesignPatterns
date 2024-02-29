using DesignPatterns.Model.Products.Additives;
using DesignPatterns.Model.Products.Lavashs;
using DesignPatterns.Model.Products.Meats;
using DesignPatterns.Model.Products.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model.Products;

namespace DesignPatterns.Model.ShawarmaFactorys
{
    public class CheeseShawarmaFactory : ShawarmaFactory
    {
        public override string CreateName()
        {
            return "Сырная шаверма";
        }

        public override Lavash CreateLavash()
        {
            return new CheeseLavash();
        }

        public override Meat CreateMeat()
        {
            return new ChickenMeat();
        }

        public override Sauce CreateSauce()
        {
            return new СreamSauce();
        }

        public override Additives CreateAdditives()
        {
            return new Additives([new Cheese()]);
        }
    }
}
