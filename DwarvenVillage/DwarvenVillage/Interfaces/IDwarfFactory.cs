using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Interfaces
{
    public interface IDwarfFactory
    {
        IList<Dwarf> Create10();
        Dwarf CreateSingle();
    }
}
