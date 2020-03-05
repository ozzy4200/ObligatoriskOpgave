using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void forfatterTest()
        {
            Bog bog = new Bog();
            bog.Forfatter = "O";
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SidetalTest()
        {
            Bog bog = new Bog();
            bog.Sidetal = 1006;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsbnTest()
        {
            Bog bog = new Bog();
            bog.Isbn13 = "yrdtfuyguttyf";
        }
    }
}