using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DwarvenVillage.Models;

namespace DwarvenVillage
{
    public class Day : IDay
    {
        private readonly IDwarfFactory _dwarfFactory;
        private int _dayNumber;

        private Day()
        {

        }

        public Day(IDwarfFactory dwarfFactory, int dayNumber)
        {
            _dwarfFactory = dwarfFactory;
            _dayNumber = dayNumber;
        }

        public IList<Dwarf> BornDwarves(IList<Dwarf> villageDwarves)
        {
            if (_dayNumber == 1)
            {
                return _dwarfFactory.Create10();
            }

            return new List<Dwarf>() { _dwarfFactory.CreateSingle() };
        }

        public IList<Dwarf> Mine(IList<Dwarf> mineDwarves, IMine mine)
        {
            return mine.Work(mineDwarves);
        }

        public IList<Dwarf> SellOres(IList<Dwarf> shopDwarves, IOreShop oreShop)
        {
            throw new NotImplementedException();
        }

        public IList<Dwarf> BuyFood(IList<Dwarf> foodDwarves, IFoodStore foodStore)
        {
            throw new NotImplementedException();
        }

        public IList<Dwarf> Feed(IList<Dwarf> hungryDwarves)
        {
            throw new NotImplementedException();
        }
    }
}
