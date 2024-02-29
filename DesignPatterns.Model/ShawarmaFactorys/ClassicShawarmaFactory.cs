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
    public class ClassicShawarmaFactory : ShawarmaFactory
    {
        public override string CreateName()
        {
            return "Классическая шаверма";
        }

        public override Lavash CreateLavash()
        {
            return new ClassicLavash();
        }

        public override Meat CreateMeat()
        {
            return new PorkMeat();
        }

        public override Sauce CreateSauce()
        {
            return new СreamSauce();
        }

        public override Additives CreateAdditives()
        {
            return new Additives();
        }
    }
}
