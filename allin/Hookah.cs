using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allin
{
    class Hookah
    {
        public List<string> Cards;
        public DateTime Start;
        public UInt16 Price;
        public UInt16 Payed;

        public Hookah()
        {
            Start = new DateTime();
        }
    }
}
