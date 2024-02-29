using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Sauces
{
    internal class СreamSauce : Sauce
    {
        public СreamSauce()
        {
            _name = "Сметанный " + _name;
            _price = 20;
        }
    }
}
