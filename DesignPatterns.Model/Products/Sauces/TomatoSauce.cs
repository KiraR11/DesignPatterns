using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Sauces
{
    internal class TomatoSauce : Sauce
    {
        public TomatoSauce()
        {
            _name = "Томатный " + _name;
            _price = 10;
        }
    }
}
