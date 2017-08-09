using DwarvenVillage.Factories;
using DwarvenVillage.Generators;
using DwarvenVillage.Interfaces;
using DwarvenVillage.Models;
using DwarvenVillage.WorkUnits;
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
        private List<IDwarf> _dwarves;
        private int _dayNumber;
        private IMine _mine;
        private IOreShop _oreShop;

        public void InitializeSimulation()
        {
            var shafts = new List<IShaft>()
            {
                new Shaft(),
                new Shaft()
            };
            _dwarves = new List<IDwarf>();
            _mine = new Mine(shafts, new NumberOfDigsGenerator());
            _oreShop = new OreShop();
            _dayNumber = 1;
            _day = new Day(new DwarfFactory(new DwarfTypeGenerator()), _dayNumber);
        }

        public void StartSimulation()
        {
            _dwarves = _day.BornDwarves(_dwarves);
            _dwarves = _day.Mine(_dwarves, _mine);
        }
    }
}
