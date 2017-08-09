using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DwarvenVillage.Models;

namespace DwarvenVillage.WorkUnits
{
    public class Mine : IMine
    {
        private IEnumerable<IShaft> _shafts;

        public Mine(IEnumerable<IShaft> shafts)
        {
            _shafts = shafts;
        }

        public IList<IDwarf> Work(IList<IDwarf> villageDwarves)
        {
            foreach (var shaft in _shafts)
            {
                villageDwarves = shaft.Dig(villageDwarves);
            }

            return villageDwarves;
        }
    }
}
