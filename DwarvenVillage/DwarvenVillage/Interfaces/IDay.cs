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
        List<IDwarf> BornDwarves(List<IDwarf> villageDwarves);
        List<IDwarf> Mine(List<IDwarf> mineDwarves, IMine mine);
        List<IDwarf> SellOres(List<IDwarf> shopDwarves, IOreShop oreShop);
        List<IDwarf> BuyFood(List<IDwarf> foodDwarves, IFoodStore foodStore);
        List<IDwarf> Feed(List<IDwarf> hungryDwarves);
    }
}
