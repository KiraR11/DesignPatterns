using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Lavashs
{
    internal class ClassicLavash : Lavash
    {
        public ClassicLavash()
        {
            _name = "Классический " + _name;
            _price = 18;
        }

    }
}
