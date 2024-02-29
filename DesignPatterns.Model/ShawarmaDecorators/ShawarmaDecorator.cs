using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.ShawarmaDecorators
{
    public abstract class ShawarmaDecorator : Shawarma
    {
        public ShawarmaDecorator(Shawarma shawarma) : base(shawarma)
        {
            Shawarma = shawarma;
        }
        protected Shawarma Shawarma { get; set; }
    }
}
