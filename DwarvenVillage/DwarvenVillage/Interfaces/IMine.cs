using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Interfaces
{
    public interface IMine
    {
        IList<IDwarf> Work(IList<IDwarf> villageDwarves);
    }
}
