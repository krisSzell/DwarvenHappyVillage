using DwarvenVillage.Factories;
using DwarvenVillage.Interfaces;
using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage
{
    public class VillageSimulator : IVillageSimulator
    {
        private IDay _day;
        private IList<Dwarf> _dwarves;
        private int _dayNumber;

        public void InitializeSimulation()
        {
            _dwarves = new List<Dwarf>();
            _dayNumber = 1;
            _day = new Day(new DwarfFactory(), _dayNumber);
        }

        public void StartSimulation()
        {
            _dwarves = _day.BornDwarves(_dwarves);
            _dwarves = _day.Mine(_dwarves);
        }
    }
}
