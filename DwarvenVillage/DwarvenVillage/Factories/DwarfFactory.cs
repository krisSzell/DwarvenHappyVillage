using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DwarvenVillage.Models;

namespace DwarvenVillage.Factories
{
    public class DwarfFactory : IDwarfFactory
    {
        public IList<Dwarf> Create10()
        {
            IList<Dwarf> dwarves = new List<Dwarf>();

            for (int i = 0; i < 10; i++)
            {
                dwarves.Add(new Dwarf());
            }

            return dwarves;
        }

        public Dwarf CreateSingle()
        {
            throw new NotImplementedException();
        }
    }
}
