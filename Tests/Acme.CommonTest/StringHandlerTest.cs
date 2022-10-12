using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // arrange
            var source = "SonicScrewdriver";
            var exptected = "Sonic Screwdriver";
            // act
            var actual = StringHandler.InsertSpaces(source);
            // assert
            Assert.AreEqual(exptected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestExistingSpace()
        {
            // arrange
            var source = "Sonic Screwdriver";
            var exptected = "Sonic Screwdriver";
            // act
            var actual = StringHandler.InsertSpaces(source);
            // assert
            Assert.AreEqual(exptected, actual);
        }
    }
}
