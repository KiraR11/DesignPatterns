using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaStrategy
{
    public interface ICost
    {
        public double Cost(Shawarma shawarma);
    }
}
