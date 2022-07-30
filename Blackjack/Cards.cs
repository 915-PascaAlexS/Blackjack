using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Cards
    {
        public int value;
        
        public void setValue(int x)
        {
            value = x;
        }
       
        public int getValue()
        {
            return value;
        }

    }
}
