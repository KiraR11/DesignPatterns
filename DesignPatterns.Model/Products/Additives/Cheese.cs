using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Additives
{
    internal class Cheese : Product
    {
        public Cheese()
        {
            _name = "Сыр";
            _price = 20;
        }
    }
}
