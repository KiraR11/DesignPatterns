using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Meats
{
    internal class PorkMeat : Meat
    {
        public PorkMeat()
        {
            _name = "Свиное " + _name;
            _price = 100;
        }
    }
}
