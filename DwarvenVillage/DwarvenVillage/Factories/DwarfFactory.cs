using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DwarvenVillage.Models;
using DwarvenVillage.Generators;

namespace DwarvenVillage.Factories
{
    public class DwarfFactory : IDwarfFactory
    {
        private static int _id = 0;
        private IRandom _typeGenerator;

        public DwarfFactory(IRandom generator)
        {
            _typeGenerator = generator;
        }

        public List<IDwarf> Create10()
        {
            List<IDwarf> dwarves = new List<IDwarf>();

            for (int i = 0; i < 10; i++)
            {
                dwarves.Add(CreateSingle());
            }

            return dwarves;
        }

        public IDwarf CreateSingle()
        {
            var dwarf = new Dwarf()
            {
                Id = _id++,
                Type = getType(),
                Ores = new List<OreType>()
            };

            return dwarf;
        }

        private DwarfType getType()
        {
            var probability = _typeGenerator.Generate();
            DwarfType result;

            if (probability <= 30)
            {
                result = DwarfType.Single;
            }
            else if (probability <= 60)
            {
                result = DwarfType.Parent;
            }
            else if (probability <= 90)
            {
                result = DwarfType.LazyBastard;
            }
            else
            {
                result = DwarfType.Saboteur;
            }

            return result;
        }
    }
}
