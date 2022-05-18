using System;
using System.Collections.Generic;
using System.Text;

namespace Sailing_Application_Delegate_
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
       
        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $" Mehsul Adi: {Name} \nMehsulun QIymeti: {Price}";
        }
    }
}
