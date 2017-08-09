using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Models
{
    public enum OreType
    {
        Mithril,
        Gold,
        Silver,
        DirtyGold,
        Rock
    }

    public struct Ore
    {
        public OreType Type { get; set; }
        public decimal Value { get; set; }
    }
}
