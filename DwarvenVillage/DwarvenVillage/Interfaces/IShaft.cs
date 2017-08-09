using System.Collections.Generic;

namespace DwarvenVillage.Interfaces
{
    public interface IShaft
    {
        bool IsOccupied { get; set; }
        bool IsOperating { get; set; }

        List<IDwarf> Dig(List<IDwarf> diggingDwarves);
        int SpotsLeft();
    }
}