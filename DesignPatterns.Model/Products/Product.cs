using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model.Products
{
    public abstract class Product
    {
        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }

        protected string _name;
        protected double _price;

        private bool _isReplicated;

        private int _countReplicat = 1;
        //срок годности
        public void AddReplicat(int count)
        {
            if (count > 0)
            {
                if (_isReplicated)
                {
                    _name = _name.Remove(_name.Length - _countReplicat.ToString().Length - 1,
                        _countReplicat.ToString().Length) + count;
                    _price += (_price / _countReplicat) * count;
                    _countReplicat += count;
                }
                else
                {
                    _name += $" x {count}";
                    _isReplicated = true;
                    _countReplicat += count;
                }
            }
            else
            {
                throw new ArgumentException("Количество копий продукта должно быть больше нуля");
            }
            
        }

    }
}
