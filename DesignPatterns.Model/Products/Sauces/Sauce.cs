using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Sauces
{
    public abstract class Sauce : Product
    {
        protected Sauce()
        {
            _name = "соус";
        }
    }
}
