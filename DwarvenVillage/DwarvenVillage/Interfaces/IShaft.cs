using System.Collections.Generic;

namespace DwarvenVillage.Interfaces
{
    public interface IShaft
    {
        IList<IDwarf> Dig(IList<IDwarf> diggingDwarves);
        int FreeSpots();
    }
}