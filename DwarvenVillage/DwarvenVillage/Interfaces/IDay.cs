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
        IList<Dwarf> BornDwarves(IList<Dwarf> villageDwarves);
        IList<Dwarf> Mine(IList<Dwarf> mineDwarves, IMine mine);
        IList<Dwarf> SellOres(IList<Dwarf> shopDwarves, IOreShop oreShop);
        IList<Dwarf> BuyFood(IList<Dwarf> foodDwarves, IFoodStore foodStore);
        IList<Dwarf> Feed(IList<Dwarf> hungryDwarves);
    }
}
