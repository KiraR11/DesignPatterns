using DesignPatterns.Model.Products;
using DesignPatterns.Model.Products.Additives;
using DesignPatterns.Model.Products.Lavashs;
using DesignPatterns.Model.Products.Meats;
using DesignPatterns.Model.Products.Sauces;

namespace DesignPatterns.Model.ShawarmaFactorys
{
    public abstract class ShawarmaFactory
    {
        public abstract string CreateName();
        public abstract Lavash CreateLavash();
        public abstract Meat CreateMeat();
        public abstract Sauce CreateSauce();
        public abstract Additives CreateAdditives();
    }
}
