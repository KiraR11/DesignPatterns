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
                _price += (_price / _countReplicat) * count;
                _countReplicat += count;
                if (_isReplicated)
                {
                    _name = _name.Remove(_name.Length - _countReplicat.ToString().Length,
                        _countReplicat.ToString().Length) + _countReplicat;
                }
                else
                {
                    _name += $" x {_countReplicat}";
                    _isReplicated = true;
                }
            }
            else
            {
                throw new ArgumentException("Количество копий продукта должно быть больше нуля");
            }
            
        }

    }
}
