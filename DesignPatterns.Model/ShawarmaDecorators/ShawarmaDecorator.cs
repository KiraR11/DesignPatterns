using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaDecorators
{
    internal abstract class ShawarmaDecorator : Shawarma
    {
        public ShawarmaDecorator(Shawarma shawarma) : base(shawarma.Factory)
        {
            Shawarma = shawarma;
        }
        protected Shawarma Shawarma { get; set; }
    }
}
