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
        private readonly IEnumerable<IShaft> _shafts;

        public IList<Dwarf> Work(IList<Dwarf> villageDwarves)
        {
            throw new NotImplementedException();
        }
    }
}
