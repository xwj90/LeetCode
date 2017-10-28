using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            Assert.AreEqual(false, new Solution().IsMatch("aa", "a"));
            Assert.AreEqual(true, new Solution().IsMatch("aa", "aa"));
            Assert.AreEqual(false, new Solution().IsMatch("aaa", "aa"));
            Assert.AreEqual(true, new Solution().IsMatch("aa", "a*"));
            Assert.AreEqual(true, new Solution().IsMatch("aa", ".*"));
            Assert.AreEqual(true, new Solution().IsMatch("ab", ".*"));
            Assert.AreEqual(false, new Solution().IsMatch("ab", ".*c"));
            Assert.AreEqual(true, new Solution().IsMatch("aab", "c*a*b"));
            Assert.AreEqual(false, new Solution().IsMatch("aaaaaaaaaaaaab", "a*a*a*a*a*a*a*a*a*a*c"));
            Assert.AreEqual(false, new Solution().IsMatch("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", "a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*a*c"));


        }

        [TestMethod()]
        public void MaxAreaTest()
        {
            Assert.AreEqual(1, new Solution().MaxArea(new int[] { 1, 1 }));
            Assert.AreEqual(2, new Solution().MaxArea(new int[] { 2, 3 }));
            Assert.AreEqual(12, new Solution().MaxArea(new int[] { 3, 3, 1, 1, 5 }));
            Assert.AreEqual(9, new Solution().MaxArea(new int[] { 1, 1, 9, 9, 1, 1 }));

        }

        [TestMethod()]
        public void ThreeSumTest()
        {
            var r = new Solution().ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            Assert.AreEqual(2, r.Count);
            Assert.IsTrue(r.All(p => p.Sum() == 0));
        }

        [TestMethod()]
        public void ThreeSumClosestTest()
        {
            Assert.AreEqual(2, new Solution().ThreeSumClosest(new int[] { -1, 2, 1, 4 }, 1));

        }

        [TestMethod()]
        public void LetterCombinationsTest()
        {

            Assert.AreEqual(9, new Solution().LetterCombinations("23").Count);            
            Assert.AreEqual(0, new Solution().LetterCombinations("").Count);

        }
    }
}