﻿using DwarvenVillage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Interfaces
{
    public interface IVillageDeposit
    {
        int GiveFood();
        int GiveMoney();
        void DepositOres(IList<OreType> ores);
    }
}
