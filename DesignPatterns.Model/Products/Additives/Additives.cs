using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Additives
{
    public class Additives
    {
        public Additives(List<Product> products)
        {
            AdditivesProduct = new List<Product>();
            foreach (Product product in products)
                Add(product);
        }

        public Additives()
        {
            AdditivesProduct = new List<Product>();
        }
        public List<Product> AdditivesProduct { get; set; }

        public double Sum()
        {
            return AdditivesProduct.Sum(x => x.GetPrice());
        }

        public void Add(Product product)
        {
            foreach (Product additiv in AdditivesProduct)
            {
                if (additiv.GetType() == product.GetType())
                {
                    additiv.AddReplicat(1);
                    return;
                }
            }
            AdditivesProduct.Add(product);
        }
    }
}
