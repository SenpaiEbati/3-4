using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Product: IComparable
    {
        private double _Weight;
        private string _Name, _Manufacturer;

        public double Weight 
        { 
            get { return _Weight; }
            set { if (value >= 0.1 && value <= 100.0) _Weight = value; }
        }

        public string Name 
        { 
            get { return _Name; }
            set { if (!string.IsNullOrWhiteSpace(value)) _Name = value; }
        }
        
        public string Manufacturer
        {
            get { return _Manufacturer; }
            set { if (!string.IsNullOrWhiteSpace(value)) _Manufacturer = value; }
        }

        public Product() : this("Не задано", "Не задан", 1.0) { }

        public Product(string Name, string Manufacturer, double Weight)
        {
            _Name = string.IsNullOrWhiteSpace(Name) ? "Не задано" : Name;
            _Manufacturer = string.IsNullOrWhiteSpace(Manufacturer) ? "Не задан" : Manufacturer;
            _Weight = Weight >= 0.1 && Weight <= 100.0 ? Weight : 1.0;
        }

        public override string ToString()
        {
            return string.Format("{0}({1}), {2}", _Name, _Manufacturer, _Weight);
        }

        public int CompareTo(object o)
        {
            if (o is Product product)
            {
                return Name.CompareTo(product.Name);
            }
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
