using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products.Additives
{
    internal class FrenchFries : Product
    {
        public FrenchFries()
        {
            _name = "Картошка фри";
            _price = 30;
        }
    }
}
