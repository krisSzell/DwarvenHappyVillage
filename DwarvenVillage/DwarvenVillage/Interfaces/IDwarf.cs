using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Interfaces
{
    public interface IDwarf
    {
        bool Explodes();
        bool Equals(object obj);
        void SetNumberOfDigs(int number);
        int GetNumberOfDigs();
    }
}
