using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Interfaces
{
    public interface IDay
    {
        void BornDwarves(IList<Dwarf> villageDwarves);
        IList<Dwarf> Mine(IList<Dwarf> mineDwarves);
        IList<Dwarf> SellOres(IList<Dwarf> shopDwarves);
        IList<Dwarf> BuyFood(IList<Dwarf> foodDwarves);
        IList<Dwarf> Feed(IList<Dwarf> hungryDwarves);
    }
}
