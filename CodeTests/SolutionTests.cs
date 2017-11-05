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

        [TestMethod()]
        public void SearchTest()
        {

            Assert.AreEqual(0, new Solution().Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 4));
            Assert.AreEqual(5, new Solution().Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 1));
            Assert.AreEqual(-1, new Solution().Search(new int[] { 4, 5, 6, 8, 0, 1, 2 }, 7));
            Assert.AreEqual(-1, new Solution().Search(new int[] { 5, 6, 7, 8, 0, 1, 2 }, 4));
        }

        [TestMethod()]
        public void LongestValidParenthesesTest()
        {
            Assert.AreEqual(0, new Solution().LongestValidParentheses(""));
            Assert.AreEqual(6, new Solution().LongestValidParentheses("()()()"));
            Assert.AreEqual(4, new Solution().LongestValidParentheses("(((((()()"));
            Assert.AreEqual(8, new Solution().LongestValidParentheses("(()()((((()()()()(("));
            Assert.AreEqual(2, new Solution().LongestValidParentheses("())"));
        }

        [TestMethod()]
        public void TrapTest()
        {
            Assert.AreEqual(6, new Solution().Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));

        }

        [TestMethod()]
        public void JumpTest()
        {
            Assert.AreEqual(2, new Solution().Jump(new int[] { 2, 3, 1, 1, 4 }));
            Assert.AreEqual(1, new Solution().Jump(new int[] { 2, 1 }));
            Assert.AreEqual(2, new Solution().Jump(new int[] { 1, 2, 0, 1 }));
            int[] aa = new int[10000];
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = 1;
            }
            Assert.AreEqual(aa.Length - 1, new Solution().Jump(aa));

        }

        [TestMethod()]
        public void MinDistanceTest()
        {
            Assert.AreEqual(0, new Solution().MinDistance("", ""));
            Assert.AreEqual(0, new Solution().MinDistance("a", "a"));
            Assert.AreEqual(2, new Solution().MinDistance("a", "abc"));
            Assert.AreEqual(2, new Solution().MinDistance("abd", "bc"));
            Assert.AreEqual(1, new Solution().MinDistance("abababa", "adbababa"));
            Assert.AreEqual(6, new Solution().MinDistance("dinitrophenylhydrazine", "acetylphenylhydrazine"));


        }

        [TestMethod()]
        public void MinWindowTest()
        {
            Assert.AreEqual("ba", new Solution().MinWindow("bba", "ab"));
            Assert.AreEqual("a", new Solution().MinWindow("a", "a"));
            Assert.AreEqual("BANC", new Solution().MinWindow("ADOBECODEBANC", "ABC"));
            Assert.AreEqual("b_ca", new Solution().MinWindow("a_b_c_________b_ca", "abc"));
        }

        [TestMethod()]
        public void LargestRectangleAreaTest()
        {

            // Assert.AreEqual(8, new Solution().LargestRectangleArea(new int[] { 1, 1, 2, 2, 3, 3, 1 }));
            Assert.AreEqual(10, new Solution().LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 }));

        }

        [TestMethod()]
        public void IsScrambleTest()
        {
            Assert.AreEqual(false, new Solution().IsScramble("abcd", "bdac"));
        }

        [TestMethod()]
        public void IsInterleaveTest()
        {
            Assert.AreEqual(true, new Solution().IsInterleave("a", "", "a"));
            Assert.AreEqual(true, new Solution().IsInterleave("aa", "ab", "abaa"));
            Assert.AreEqual(true, new Solution().IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
            Assert.AreEqual(false, new Solution().IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
            Assert.AreEqual(false, new Solution().IsInterleave(
           "bbbbbabbbbabaababaaaabbababbaaabbabbaaabaaaaababbbababbbbbabbbbababbabaabababbbaabababababbbaaababaa",
"babaaaabbababbbabbbbaabaabbaabbbbaabaaabaababaaaabaaabbaaabaaaabaabaabbbbbbbbbbbabaaabbababbabbabaab",
"babbbabbbaaabbababbbbababaabbabaabaaabbbbabbbaaabbbaaaaabbbbaabbaaabababbaaaaaabababbababaababbababbbababbbbaaaabaabbabbaaaaabbabbaaaabbbaabaaabaababaababbaaabbbbbabbbbaabbabaabbbbabaaabbababbabbabbab"));
        }

        [TestMethod()]
        public void MaxProfitTest()
        {
            Assert.AreEqual(6, new Solution().MaxProfit(new int[] { 3, 2, 6, 7, 4, 5 }));
            Assert.AreEqual(0, new Solution().MaxProfit(new int[] { }));
            Assert.AreEqual(0, new Solution().MaxProfit(new int[] { 1 }));
            Assert.AreEqual(0, new Solution().MaxProfit(new int[] { 2, 1 }));
            Assert.AreEqual(1, new Solution().MaxProfit(new int[] { 1, 2 }));


        }

        [TestMethod()]
        public void MaxPathSumTest()
        {
            Assert.AreEqual(-1000, new Solution().MaxPathSum(TreeNode.Create(new int[] { -1000, -2000, -3000 })));
            Assert.AreEqual(-1000, new Solution().MaxPathSum(TreeNode.Create(new int[] { -3000, -2000, -1000 })));
            Assert.AreEqual(4, new Solution().MaxPathSum(TreeNode.Create(new int[] { 1, -2, 3 })));
            Assert.AreEqual(1, new Solution().MaxPathSum(TreeNode.Create(new int[] { -2, 1 })));
            Assert.AreEqual(-2, new Solution().MaxPathSum(TreeNode.Create(new int[] { -2 })));
            Assert.AreEqual(1, new Solution().MaxPathSum(TreeNode.Create(new int[] { 1 })));
            Assert.AreEqual(26, new Solution().MaxPathSum(TreeNode.Create(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
        }
    }
}