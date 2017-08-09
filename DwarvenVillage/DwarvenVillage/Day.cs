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

        public List<IDwarf> BornDwarves(List<IDwarf> villageDwarves)
        {
            if (_dayNumber == 1)
            {
                return _dwarfFactory.Create10();
            }

            return new List<IDwarf>() { _dwarfFactory.CreateSingle() };
        }

        public List<IDwarf> Mine(List<IDwarf> mineDwarves, IMine mine)
        {
            return mine.Work(mineDwarves);
        }

        public List<IDwarf> SellOres(List<IDwarf> shopDwarves, IOreShop oreShop)
        {
            throw new NotImplementedException();
        }

        public List<IDwarf> BuyFood(List<IDwarf> foodDwarves, IFoodStore foodStore)
        {
            throw new NotImplementedException();
        }

        public List<IDwarf> Feed(List<IDwarf> hungryDwarves)
        {
            throw new NotImplementedException();
        }
    }
}
