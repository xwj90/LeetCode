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

        [TestMethod()]
        public void RemoveNthFromEndTest()
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);
            var result = new Solution().RemoveNthFromEnd(node, 2);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(5, result.next.next.next.val);
        }

        [TestMethod()]
        public void IsValidTest()
        {

            Assert.AreEqual(true, new Solution().IsValid("()"));
            Assert.AreEqual(true, new Solution().IsValid("()[]"));
            Assert.AreEqual(true, new Solution().IsValid("(())"));
            Assert.AreEqual(true, new Solution().IsValid("{()[]}"));
            Assert.AreEqual(false, new Solution().IsValid("([)]"));
            Assert.AreEqual(false, new Solution().IsValid("(((("));
        }

        [TestMethod()]
        public void MergeTwoListsTest()
        {
            var a = ListNode.Create(new int[] { 1, 2, 3, 4, 5, 6 });
            var b = ListNode.Create(new int[] { 1, 3, 5, 7, 9, 11 });
            var c = ListNode.Create(new int[] { 2, 4, 6, 8, 10, 12 });

            var r1 = ListNode.Create(new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 9, 11 });
            Assert.AreEqual(r1, new Solution().MergeTwoLists(a, b));
        }

        [TestMethod()]
        public void GenerateParenthesisTest()
        {
            Assert.AreEqual("()", new Solution().GenerateParenthesis(1).First());

        }

        [TestMethod()]
        public void SwapPairsTest()
        {
            var a = ListNode.Create(new int[] { 1, 2, 3, 4 });
            var b = ListNode.Create(new int[] { 2, 1, 4, 3 });
            Assert.AreEqual(b, new Solution().SwapPairs(a));
        }

        [TestMethod()]
        public void ReverseKGroupTest()
        {

            var a2 = ListNode.Create(new int[] { 2, 1, 4, 3, 5 });
            var a3 = ListNode.Create(new int[] { 3, 2, 1, 4, 5 });
            Assert.AreEqual(a2, new Solution().ReverseKGroup(ListNode.Create(new int[] { 1, 2, 3, 4, 5 }), 2));
            Assert.AreEqual(a3, new Solution().ReverseKGroup(ListNode.Create(new int[] { 1, 2, 3, 4, 5 }), 3));
        }

        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            Assert.AreEqual(3, new Solution().RemoveDuplicates(new int[] { 1, 2, 3 }));
            Assert.AreEqual(2, new Solution().RemoveDuplicates(new int[] { 1, 1, 2 }));
            Assert.AreEqual(8, new Solution().RemoveDuplicates(new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 7, 7, 8 }));

        }

        [TestMethod()]
        public void StrStrTest()
        {
            Assert.AreEqual(0, new Solution().StrStr("", ""));
            Assert.AreEqual(0, new Solution().StrStr("abc", "abc"));
            Assert.AreEqual(3, new Solution().StrStr("aaaabc", "ab"));
            Assert.AreEqual(-1, new Solution().StrStr("aaa", "aaaa"));
         


        }
    }
}