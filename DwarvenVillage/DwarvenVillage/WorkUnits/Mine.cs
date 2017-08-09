using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DwarvenVillage.Models;
using DwarvenVillage.Generators;

namespace DwarvenVillage.WorkUnits
{
    public class Mine : IMine
    {
        private IEnumerable<IShaft> _shafts;
        private IRandom _generator;

        public Mine(IEnumerable<IShaft> shafts, IRandom generator)
        {
            _generator = generator;
            _shafts = shafts;
        }

        public IList<IDwarf> Work(IList<IDwarf> villageDwarves)
        {
            giveDwarvesNumberOfDigs(villageDwarves);

            foreach (var shaft in _shafts)
            {
                villageDwarves = shaft.Dig(villageDwarves);
            }

            return villageDwarves;
        }

        private void giveDwarvesNumberOfDigs(IList<IDwarf> dwarves)
        {
            foreach (var dwarf in dwarves)
            {
                dwarf.SetNumberOfDigs(_generator.Generate());
            }
        }
    }
}
