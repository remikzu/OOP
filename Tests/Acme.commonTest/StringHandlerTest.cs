using System;
using Acme.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.commonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValidTest()
        {
            // Arrange
            string str1 = "RemigiuszZudzin";
            string expected = "Remigiusz Zudzin";
            // Act
            string actual = str1.InsertSpaces();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesValidTest2()
        {
            // Arrange
            string str2 = "RadoslawPietrowskiRemigiuszZudzinArturHatleMichalPanfil";
            string expected2 = "Radoslaw Pietrowski Remigiusz Zudzin Artur Hatle Michal Panfil";
            // Act
            string actual2 = str2.InsertSpaces();
            // Assert
            Assert.AreEqual(expected2, actual2);
        }
    }
}
