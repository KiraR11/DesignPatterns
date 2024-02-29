using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaStrategy
{
    public class StudentDiscount : IDiscount
    {
        double IDiscount.Discount()
        {
            return 0.9;
        }
    }
}
