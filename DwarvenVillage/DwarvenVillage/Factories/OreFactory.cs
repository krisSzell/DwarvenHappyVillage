using DwarvenVillage.Generators;
using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Factories
{
    public class OreFactory
    {
        private IRandom _typeGenerator;

        public OreFactory(IRandom generator)
        {
            _typeGenerator = generator;
        }

        public OreType Create()
        {
            var probability = _typeGenerator.Generate();
            OreType result;

            if (probability <= 5)
            {
                result = OreType.Mithril;
            }
            else if (probability <= 10)
            {
                result = OreType.Gold;
            }
            else if (probability <= 20)
            {
                result = OreType.Silver;
            }
            else if (probability <= 50)
            {
                result = OreType.DirtyGold;
            }
            else
            {
                result = OreType.Rock;
            }

            return result;
        }
    }
}
