using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Interfaces
{
    public interface IDwarf
    {
        int Id { get; set; }
        DwarfType Type { get; set; }
        IList<OreType> Ores { get; set; }
        int NumberOfDigs { get; set; }

        bool Explodes();
        bool Equals(object obj);
    }
}
