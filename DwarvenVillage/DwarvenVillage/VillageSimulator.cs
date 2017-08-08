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

        public VillageSimulator()
        {
            _dwarves = new List<Dwarf>();
        }

        public void InitializeSimulation()
        {
            _day = new Day();
        }

        public void StartSimulation()
        {
            _dwarves = _day.BornDwarves(_dwarves);
            _dwarves = _day.Mine(_dwarves);
        }
    }
}
