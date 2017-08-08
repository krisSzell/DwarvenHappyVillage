using DwarvenVillage.Factories;
using DwarvenVillage.Models;
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
            var factory = new DwarfFactory();
            int expected = 10;

            // when
            var result = factory.Create10();

            // then
            Assert.AreEqual(expected, result.Count);
            Assert.IsTrue(result.Distinct().Count() == result.Count);
        }
    }
}
