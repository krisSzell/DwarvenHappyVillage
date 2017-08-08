using DwarvenVillage.Interfaces;
using DwarvenVillage.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DwarvenVillage.Tests
{
    public class DayTests
    {
        private IList<Dwarf> _tenDwarves;

        [SetUp]
        public void Init()
        {
            int id = 0;
            _tenDwarves = new List<Dwarf>();

            for (int i = 0; i < 10; i++)
            {
                _tenDwarves.Add(new Dwarf(id++));
            }
        }

        [Test]
        public void ShouldReturnListOf10DwarvesOnDay1()
        {
            // given
            var factoryMock = new Mock<IDwarfFactory>();
            factoryMock.Setup(f => f.Create10()).Returns(_tenDwarves);
            var day = new Day(factoryMock.Object, 1);
            var expected = _tenDwarves;
            // when
            var result = day.BornDwarves(new List<Dwarf>());
            // then
            Assert.AreEqual(expected.Count, result.Count);
        }

        [Test]
        public void ShouldReturnListOf1Or0DwarvesOnDayOtherThanFirst()
        {
            // given
            var factoryMock = new Mock<IDwarfFactory>();
            factoryMock.Setup(f => f.CreateSingle()).Returns(new Dwarf(0));
            var day = new Day(factoryMock.Object, 2);
            // when
            var result = day.BornDwarves(new List<Dwarf>());
            // then
            Assert.IsTrue(result.Count == 1 || result.Count == 0);
        }
    }
}
