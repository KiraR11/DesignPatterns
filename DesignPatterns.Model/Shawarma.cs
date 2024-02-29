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
        private IDiscount _discount;
        public void SetDiscount(IDiscount discount)
        {
            _discount = discount;
        }

        public double Discount()
        {
            if (_discount is null)
            {
                return Cost();
            }
            return Cost() * _discount.Discount();
        }
        public string Name { get; protected set; }
        public Lavash Lavash { get;}
        public Meat Meat { get;}
        public Sauce Sauce { get;}
        public Additives Additives { get;}

        private double Cost() 
        {
            return (Lavash.GetPrice() + Meat.GetPrice() + Sauce.GetPrice() + Additives.Sum());
        }
    }
}
