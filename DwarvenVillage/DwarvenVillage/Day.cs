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

        public IList<IDwarf> BornDwarves(IList<IDwarf> villageDwarves)
        {
            if (_dayNumber == 1)
            {
                return _dwarfFactory.Create10();
            }

            return new List<IDwarf>() { _dwarfFactory.CreateSingle() };
        }

        public IList<IDwarf> Mine(IList<IDwarf> mineDwarves, IMine mine)
        {
            return mine.Work(mineDwarves);
        }

        public IList<IDwarf> SellOres(IList<IDwarf> shopDwarves, IOreShop oreShop)
        {
            throw new NotImplementedException();
        }

        public IList<IDwarf> BuyFood(IList<IDwarf> foodDwarves, IFoodStore foodStore)
        {
            throw new NotImplementedException();
        }

        public IList<IDwarf> Feed(IList<IDwarf> hungryDwarves)
        {
            throw new NotImplementedException();
        }
    }
}
