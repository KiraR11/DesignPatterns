using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Lavashs
{
    public abstract class Lavash : Product
    {
        protected Lavash()
        {
            _name = "лаваш";
        }
    }
}
