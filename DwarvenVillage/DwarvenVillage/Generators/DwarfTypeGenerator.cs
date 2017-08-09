using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Generators
{
    public class DwarfTypeGenerator : IRandom
    {
        Random rnd = new Random(DateTime.Now.Millisecond);

        public int Generate()
        {
            return rnd.Next(1, 101);
        }
    }
}
