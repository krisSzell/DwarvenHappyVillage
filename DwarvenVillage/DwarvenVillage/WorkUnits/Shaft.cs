using DwarvenVillage.Interfaces;
using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.WorkUnits
{
    public class Shaft : IShaft
    {
        private int _spotsLeft = 5;
        public bool IsOccupied { get; set; }
        public bool IsOperating { get; set; }

        public List<IDwarf> Dig(List<IDwarf> diggingDwarves)
        {
            IsOccupied = true;
            foreach (var dwarf in diggingDwarves)
            {
                //if (dwarf != null)
                //{
                    dwarf.Ores.Add(OreType.Mithril);
                    dwarf.NumberOfDigs--;
                    Console.WriteLine($"{dwarf.Id} dig nothing (for now)");
                //}
            }

            return diggingDwarves;
        }

        public int SpotsLeft()
        {
            return _spotsLeft;
        }
    }
}
