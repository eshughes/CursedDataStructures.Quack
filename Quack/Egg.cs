using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quack
{
    public class Egg : IEgg
    {
        internal Egg() 
        { 
        }

        public Duck Hatch()
        {
            return new Duck();
        }
    }
}
