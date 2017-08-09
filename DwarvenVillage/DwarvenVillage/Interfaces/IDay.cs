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
        IList<IDwarf> BornDwarves(IList<IDwarf> villageDwarves);
        IList<IDwarf> Mine(IList<IDwarf> mineDwarves, IMine mine);
        IList<IDwarf> SellOres(IList<IDwarf> shopDwarves, IOreShop oreShop);
        IList<IDwarf> BuyFood(IList<IDwarf> foodDwarves, IFoodStore foodStore);
        IList<IDwarf> Feed(IList<IDwarf> hungryDwarves);
    }
}
