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
        private static int _id = 0;

        public IList<Dwarf> Create10()
        {
            IList<Dwarf> dwarves = new List<Dwarf>();

            for (int i = 0; i < 10; i++)
            {
                dwarves.Add(new Dwarf(_id++));
            }

            return dwarves;
        }

        public Dwarf CreateSingle()
        {
            return new Dwarf(_id);
        }
    }
}
