using DwarvenVillage.Factories;
using DwarvenVillage.Generators;
using DwarvenVillage.Interfaces;
using DwarvenVillage.Models;
using DwarvenVillage.WorkUnits;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DwarvenVillage.Tests
{
    public class MineTests
    {
        private List<IDwarf> _tenDwarves;
        private List<IDwarf> _tenDwarves2;
        private List<IDwarf> _5Dwarves;

        [SetUp]
        public void Init()
        {
            _tenDwarves = new List<IDwarf>();
            var factory = new DwarfFactory(new DwarfTypeGenerator());

            _tenDwarves = factory.Create10();
            _tenDwarves2 = factory.Create10();
            _5Dwarves = new List<IDwarf>()
            {
                factory.CreateSingle(),
                factory.CreateSingle(),
                factory.CreateSingle(),
                factory.CreateSingle(),
                factory.CreateSingle()
            };
        }

    }
}
