using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terra.World.Data;

namespace Terra.World.Tests
{
    /// <summary>
    /// Eine Testklasse, welche die Klasse Terra.World.Data.Field testet.
    /// </summary>
    [TestClass]
    public class FieldTest
    {
        /// <summary>
        /// Testet die Walkable Methode.
        /// </summary>
        [TestMethod]
        public void IsFieldWalkableTest()
        {
            Density densityToTest = Density.Empty;
            bool exceptedValue = true;

            Field target = new Field(0,0,densityToTest);

            Assert.AreEqual(exceptedValue, target.IsWalkable());

            densityToTest = Density.Solid;
            target = new Field(0, 0, densityToTest);
            exceptedValue = false;

            Assert.AreEqual(exceptedValue, target.IsWalkable());
        }
    }
}
