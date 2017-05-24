using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allin
{
    class Assortiment
    {
        public string Name;
        public UInt16 Price;

        public Assortiment(string name, UInt16 price)
        {
            Name = name;
            Price = price;
        }
    }
}
