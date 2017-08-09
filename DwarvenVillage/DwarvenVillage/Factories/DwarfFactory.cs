﻿using DwarvenVillage.Interfaces;
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

        public DwarfFactory(IRandom typeGenerator)
        {
            _typeGenerator = typeGenerator;
        }

        public IList<Dwarf> Create10()
        {
            IList<Dwarf> dwarves = new List<Dwarf>();

            for (int i = 0; i < 10; i++)
            {
                dwarves.Add(CreateSingle());
            }

            return dwarves;
        }

        public Dwarf CreateSingle()
        {
            var dwarf = new Dwarf()
            {
                Id = _id++,
                Type = getType()
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
