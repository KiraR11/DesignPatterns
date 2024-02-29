using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Meats
{
    internal class SoyMeat : Meat
    {
        public SoyMeat()
        {
            _name = "Соевое " + _name;
            _price = 90;
        }
    }
}
