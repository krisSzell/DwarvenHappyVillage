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
        private bool _operating = true;

        public IList<IDwarf> Dig(IList<IDwarf> diggingDwarves)
        {
            var dwarvesToReturn = new List<IDwarf>();

            foreach (var dwarf in diggingDwarves)
            {

            }

            return diggingDwarves;
        }

        public int FreeSpots()
        {
            return _freeSpots;
        }

        public bool IsOperating()
        {
            return _operating;
        }
    }
}
