using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Models
{
    public class Dwarf : IDwarf
    {
        public int Id { get; set; }
        public DwarfType Type { get; set; }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            Dwarf dwarf = (Dwarf)obj;
            if (dwarf.Id == this.Id && dwarf.Type == this.Type)
            {
                isEqual = true;
            }

            return isEqual;
        }

        public bool Explodes()
        {
            return Type == DwarfType.Saboteur ? true : false;
        }
    }
}
