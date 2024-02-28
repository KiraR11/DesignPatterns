using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Meats
{
    public abstract class Meat : Product
    {
        protected Meat()
        {
            _name = "мясо";
        }
    }
}
