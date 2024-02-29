using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Meats
{
    internal class ChickenMeat : Meat
    {
        public ChickenMeat()
        {
            _name = "Куриное " + _name;
            _price = 80;
        }
    }
}
