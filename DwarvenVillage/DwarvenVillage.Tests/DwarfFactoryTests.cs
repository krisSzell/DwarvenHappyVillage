using DwarvenVillage.Factories;
using DwarvenVillage.Generators;
using DwarvenVillage.Interfaces;
using DwarvenVillage.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DwarvenVillage.Tests
{
    public class DwarfFactoryTests
    {
        [Test]
        public void ShouldCreateSetOf10DwarvesWithUniqueIds()
        {
            // given
            var factory = new DwarfFactory(new DwarfTypeGenerator());
            int expected = 10;

            // when
            var result = factory.Create10();

            // then
            Assert.AreEqual(expected, result.Count);
            Assert.IsTrue(result.Distinct().Count() == result.Count);
        }

        [Test]
        public void ShouldCreateDwarfOfTypeParent()
        {
            // given
            var generatorMock = new Mock<IRandom>();
            generatorMock.Setup(f => f.Generate()).Returns(0);
            var factory = new DwarfFactory(generatorMock.Object);

            var expected = new Dwarf() { Type = DwarfType.Parent };

            // when
            var result = factory.CreateSingle();

            // then
            Assert.AreEqual(expected, result);
        }
    }
}
