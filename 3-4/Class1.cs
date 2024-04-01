using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Product: IComparable<Product>
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

        public override bool Equals(object obj)
        {
            if (obj != null && GetType() == obj.GetType())
                return this == (obj as Product);
            else
                return false;
        }

        public int CompareTo(Product o)
        {
            if (_Name.CompareTo(o._Name) != 0)
                return _Name.CompareTo(o._Name);
            else
                if (_Manufacturer.CompareTo(o._Manufacturer) != 0)
                    return _Manufacturer.CompareTo(o._Manufacturer);
                else
                    return _Weight.CompareTo(o._Weight);
        }

        public override int GetHashCode()
        {
            return _Name.GetHashCode() ^ _Manufacturer.GetHashCode() ^ _Weight.GetHashCode();
        }
    }
}
