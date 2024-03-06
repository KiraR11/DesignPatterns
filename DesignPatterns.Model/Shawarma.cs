using System;
using DesignPatterns.Model.Products;
using DesignPatterns.Model.Products.Additives;
using DesignPatterns.Model.Products.Lavashs;
using DesignPatterns.Model.Products.Meats;
using DesignPatterns.Model.Products.Sauces;
using DesignPatterns.Model.ShawarmaFactorys;
using DesignPatterns.Model.ShawarmaStrategy;

namespace DesignPatterns.Model
{
    public class Shawarma
    {
        public Shawarma(ShawarmaFactory factory)
        {
            Name = factory.CreateName();
            Lavash = factory.CreateLavash();
            Meat = factory.CreateMeat();
            Sauce = factory.CreateSauce();
            Additives = factory.CreateAdditives();
        }
        protected Shawarma(Shawarma shawarma)
        {
            Name = shawarma.Name;
            Lavash = shawarma.Lavash;
            Meat = shawarma.Meat;
            Sauce = shawarma.Sauce;
            Additives = shawarma.Additives;
        }

        public IDiscount Discount {private get; set; }

        public double Cost()
        {
            if (Discount is null)
            {
                return (Lavash.GetPrice() + Meat.GetPrice() + Sauce.GetPrice() + Additives.Sum());
            }
            return Discount.Discount(this);
        }

        public virtual TimeOnly GetCookingTime()
        {
            return new TimeOnly(0, 2);
        }
        public string Name { get; protected set; }
        public Lavash Lavash { get;}
        public Meat Meat { get;}
        public Sauce Sauce { get;}
        public Additives Additives { get;}
    }
}
