using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.WorkUnits
{
    public class Shaft : IShaft
    {
        private int _freeSpots = 5;

        public IList<IDwarf> Dig(IList<IDwarf> diggingDwarves)
        {
            throw new NotImplementedException();
        }

        public int FreeSpots()
        {
            return _freeSpots;
        }
    }
}
