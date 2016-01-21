using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tests
{
    [TestClass()]
    public class SystemStringTests
    {
        [TestMethod()]
        public void ToStringTest1()
        {
            string expected = "qwertyuiop";
            SystemString SString = new SystemString(expected);
            string actual = SString.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ToStringTest2()
        {
            string expected = "qwertyuiop";
            SystemArrayString SAString = new SystemArrayString(expected);
            string actual = SAString.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ToStringTest3()
        {
            string expected = "qwertyuiop";
            SystemLinkedListString SLLString = new SystemLinkedListString(expected);
            string actual = SLLString.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ToStringTest4()
        {
            string expected = "qwertyuiop";
            CustomLinkedListString CLString = new CustomLinkedListString(expected);
            string actual = CLString.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}