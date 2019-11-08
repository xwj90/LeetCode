using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class Solution1Tests
    {
        [TestMethod()]
        public void WordBreakTest()
        {
            Assert.AreEqual(true, new Solution1().WordBreak("leetcode", new List<string>() { "leet", "code" }));

        }

        [TestMethod()]
        public void CalculateTest()
        {
            Assert.AreEqual(7, new Solution1().Calculate("3+2*2"));
            Assert.AreEqual(1, new Solution1().Calculate("3/2"));
            Assert.AreEqual(5, new Solution1().Calculate("3+5/2")); 

        }
    }
}