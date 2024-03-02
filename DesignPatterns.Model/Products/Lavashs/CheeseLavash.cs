using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Lavashs
{
    internal class CheeseLavash : Lavash
    {
        public CheeseLavash()
        {
            _name = "Сырный " + _name;
            _price = 100;
        }
    }
}
