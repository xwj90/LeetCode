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

        [TestMethod()]
        public void MinCutTest()
        {
            Assert.AreEqual(0, new Solution().MinCut("aba"));
        }

        [TestMethod()]
        public void WordBreakTest()
        {
            Assert.AreEqual(0, new Solution().WordBreak("catsanddog", new List<string>() { "cat", "cats", "and", "sand", "dog" }));
        }

        [TestMethod()]
        public void MaxPointsTest()
        {
            var points = new Point[] { new Point(84, 250), new Point(0, 0), new Point(1, 0), new Point(0, -70), new Point(0, -70), new Point(1, -1), new Point(21, 10), new Point(42, 90), new Point(-42, -230) };
            Assert.AreEqual(6, new Solution().MaxPoints(points));
            points = new Point[] { new Point(0, 0) };
            Assert.AreEqual(1, new Solution().MaxPoints(points));

            points = new Point[] { new Point(0, 0), new Point(1, 1), new Point(2, 2) };
            Assert.AreEqual(3, new Solution().MaxPoints(points));
            points = new Point[] { new Point(0, 0), new Point(-1, -1), new Point(2, 2) };
            Assert.AreEqual(3, new Solution().MaxPoints(points));
            points = new Point[] { new Point(1, 1), new Point(1, 1), new Point(2, 2), new Point(2, 2) };
            Assert.AreEqual(4, new Solution().MaxPoints(points));
            points = new Point[] { new Point(0, 0), new Point(94911151, 94911150), new Point(94911152, 94911151) };
            Assert.AreEqual(2, new Solution().MaxPoints(points));


        }

        [TestMethod()]
        public void SearchRangeTest()
        {
            var r = new Solution().SearchRange(new int[] { 2, 2 }, 3);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);

            r = new Solution().SearchRange(new int[] { 2, 2 }, 1);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);

            r = new Solution().SearchRange(new int[] { 1, 1, 3, 3 }, 2);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
            r = new Solution().SearchRange(new int[] { 1, 3, 3 }, 2);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);

            r = new Solution().SearchRange(new int[] { 1, 2, 3, 4, 5, 6 }, 5);
            Assert.AreEqual(4, r[0]);
            Assert.AreEqual(4, r[1]);


            r = new Solution().SearchRange(new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 5, 5, 6 }, 5);
            Assert.AreEqual(4, r[0]);
            Assert.AreEqual(9, r[1]);

            r = new Solution().SearchRange(new int[] { }, 5);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
            r = new Solution().SearchRange(new int[] { 5 }, 5);
            Assert.AreEqual(0, r[0]);
            Assert.AreEqual(0, r[1]);

            r = new Solution().SearchRange(new int[] { 2, 2 }, 3);
            Assert.AreEqual(-1, r[0]);
            Assert.AreEqual(-1, r[1]);
        }

        [TestMethod()]
        public void FindMinTest()
        {
            Assert.AreEqual(1, new Solution().FindMin(new int[] { 3, 1 }));
        }

        [TestMethod()]
        public void CalculateTest()
        {
            Assert.AreEqual(30, new Solution().Calculate("   30"));
            Assert.AreEqual(2, new Solution().Calculate("1+2+3-4"));


            Assert.AreEqual(1, new Solution().Calculate("1"));
            Assert.AreEqual(1, new Solution().Calculate("(1)"));
        }

        [TestMethod()]
        public void CountDigitOneTest()
        {
            Assert.AreEqual(1737167499, new Solution().CountDigitOne(1410065408));
        }

        [TestMethod()]
        public void MaxSlidingWindowTest()
        {
            Assert.AreEqual("3,3,5,5,6,7", new Solution().MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3).ToCompareString());
            Assert.AreEqual("4,3,5", new Solution().MaxSlidingWindow(new int[] { 4, 3, 2, 1, 5 }, 3).ToCompareString());
            Assert.AreEqual("7,4", new Solution().MaxSlidingWindow(new int[] { 7, 2, 4 }, 2).ToCompareString());
        }

        [TestMethod()]
        public void AddStringsTest()
        {
            Assert.AreEqual("10", new Solution().AddStrings("1", "9"));
            Assert.AreEqual("3", new Solution().AddStrings("1", "2"));
            Assert.AreEqual("145357655744", new Solution().AddStrings("12312312", "145345343432"));

        }

        [TestMethod()]
        public void WiggleMaxLengthTest()
        {
            Assert.AreEqual(6, new Solution().WiggleMaxLength(new int[] { 2, 1, 4, 5, 6, 3, 3, 4, 8, 4 }));
            Assert.AreEqual(7, new Solution().WiggleMaxLength(new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 }));
            Assert.AreEqual(6, new Solution().WiggleMaxLength(new int[] { 1, 7, 4, 9, 2, 5 }));
            Assert.AreEqual(2, new Solution().WiggleMaxLength(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));

            Assert.AreEqual(1, new Solution().WiggleMaxLength(new int[] { 84 }));
            Assert.AreEqual(1, new Solution().WiggleMaxLength(new int[] { 0, 0 }));
        }

        [TestMethod()]
        public void ConvertToBase7Test()
        {
            Assert.AreEqual("202", new Solution().ConvertToBase7(100));
            Assert.AreEqual("-10", new Solution().ConvertToBase7(-7));
        }

        [TestMethod()]
        public void DecodeStringTest()
        {
            Assert.AreEqual("accaccacc", new Solution().DecodeString("3[a2[c]]"));

            Assert.AreEqual("aaabcbc", new Solution().DecodeString("3[a]2[bc]"));
            Assert.AreEqual("abcabccdcdcdef", new Solution().DecodeString("2[abc]3[cd]ef"));


        }

        [TestMethod()]
        public void MinStickersTest()
        {
            //Assert.AreEqual(3, new Solution().MinStickers(new string[] { "with", "example", "science" }, "thehat"));
            //Assert.AreEqual(-1, new Solution().MinStickers(new string[] { "notice", "possible" }, "basicbasic"));
            var s = new Solution();
            for (int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(4, s.MinStickers(new string[] { "all", "chord", "doctor", "dance", "drive", "ready", "phrase", "skill", "dress", "select", "if", "develop", "space", "broad", "lone", "was", "fight", "how", "window", "place", "has", "plural", "star", "complete", "though", "rub", "practice", "here", "nation", "dark", "job", "observe", "key", "hole", "short", "last", "neck", "oh", "science", "industry", "work", "gun", "rule", "magnet", "stead", "many", "push", "tall", "soft", "road" }, "thosecontinent"));

            }


        }

        [TestMethod()]
        public void SortColorsTest()
        {
            var s = new int[] { 2 };
            new Solution().SortColors(s);
            Assert.AreEqual("2", s.ToCompareString());

            s = new int[] { 1, 2 };
            new Solution().SortColors(s);
            Assert.AreEqual("1,2", s.ToCompareString());

            s = new int[] { 0, 0, 2, 2, 1, 2 };
            new Solution().SortColors(s);
            Assert.AreEqual("0,0,1,2,2,2", s.ToCompareString());
        }

        [TestMethod()]
        public void CanCompleteCircuitTest()
        {
            Assert.AreEqual(0, new Solution().CanCompleteCircuit(new int[] { 5 }, new int[] { 5 }));

            Assert.AreEqual(0, new Solution().CanCompleteCircuit(new int[] { 5 }, new int[] { 4 }));
            Assert.AreEqual(-1, new Solution().CanCompleteCircuit(new int[] { 4 }, new int[] { 5 }));
            Assert.AreEqual(0, new Solution().CanCompleteCircuit(new int[] { 20, 3, 4, 5 }, new int[] { 8, 8, 8, 8 }));
            Assert.AreEqual(2, new Solution().CanCompleteCircuit(new int[] { 3, 3, 18, 5 }, new int[] { 7, 7, 7, 7 }));
            Assert.AreEqual(2, new Solution().CanCompleteCircuit(new int[] { 6, 1, 4, 3, 5 }, new int[] { 3, 8, 2, 4, 2 }));


        }

        [TestMethod()]
        public void RotateTest()
        {
            int[,] m = new int[3, 3];
            int v = 1;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = v++;
            new Solution().Rotate(m);
        }



        [TestMethod()]
        public void MyPowTest()
        {
            Assert.AreEqual(1024, new Solution().MyPow(2, 10));

        }

        [TestMethod()]
        public void CombinationSumTest()
        {
            var v = new Solution().CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            Assert.AreEqual(2, v.Count);
        }
        [TestMethod()]
        public void CombinationSum2Test()
        {
            var v = new Solution().CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
            Assert.AreEqual(4, v.Count);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual("882", new Solution().Multiply("98", "9"));
            Assert.AreEqual("0", new Solution().Multiply("9133", "0"));
            Assert.AreEqual("11847118270947654215295672156394918945481303589303314641374935669609830920", new Solution().Multiply("2502044422132801038372", "4734975193145809220560772055990393780592828328442610"));

        }

        [TestMethod()]
        public void PermuteTest()
        {
            Assert.AreEqual(6, new Solution().Permute(new int[] { 1, 2, 3 }).Count);
        }

        [TestMethod()]
        public void PermuteUniqueTest()
        {
            Assert.AreEqual(3, new Solution().PermuteUnique(new int[] { 1, 1, 2 }).Count);
            Assert.AreEqual(6, new Solution().PermuteUnique(new int[] { 1, 2, 3 }).Count);
        }

        [TestMethod()]
        public void CoinChangeTest()
        {
            Assert.AreEqual(-1, new Solution().CoinChange(new int[] { 2 }, 3));
            Assert.AreEqual(0, new Solution().CoinChange(new int[] { 1 }, 0));
            Assert.AreEqual(3, new Solution().CoinChange(new int[] { 1, 2, 5 }, 11));

        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(-2147483648, new Solution().Divide(-2147483648, 1));

        }

        [TestMethod()]
        public void NumDecodingsTest()
        {
            Assert.AreEqual(2, new Solution().NumDecodings("12"));
            Assert.AreEqual(0, new Solution().NumDecodings(""));
            Assert.AreEqual(0, new Solution().NumDecodings("0"));
            Assert.AreEqual(1, new Solution().NumDecodings("1"));
        }

        [TestMethod()]
        public void SimplifyPathTest()
        {
            Assert.AreEqual("/", new Solution().SimplifyPath("/.."));
            Assert.AreEqual("/", new Solution().SimplifyPath("/."));
            Assert.AreEqual("/c", new Solution().SimplifyPath("/a/./b/../../c/"));
            Assert.AreEqual("/home", new Solution().SimplifyPath("/home/"));
            Assert.AreEqual("/home/abc", new Solution().SimplifyPath("/home/abc/"));
            Assert.AreEqual("/", new Solution().SimplifyPath("/"));
            Assert.AreEqual("/home/foo/.ssh2/authorized_keys", new Solution().SimplifyPath("/home/foo/.ssh/../.ssh2/authorized_keys/"));




        }

        [TestMethod()]
        public void LeastIntervalTest()
        {
            Assert.AreEqual(8, new Solution().LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2));

        }

        [TestMethod()]
        public void FindLaddersTest()
        {
            Assert.Fail();
            Assert.AreEqual(3, new Solution().FindLadders("red", "tax", new List<string>() { "ted", "tex", "red", "tax", "tad", "den", "rex", "pee" }).Count);


            Assert.AreEqual(2, new Solution().FindLadders("hit", "cog", new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" }).Count);

            Assert.AreEqual(2, new Solution().FindLadders(
                     "qa", "sq", new List<string>() { "si", "go", "se", "cm", "so", "ph", "mt", "db", "mb", "sb", "kr", "ln", "tm", "le", "av", "sm", "ar", "ci", "ca", "br", "ti", "ba", "to", "ra", "fa", "yo", "ow", "sn", "ya", "cr", "po", "fe", "ho", "ma", "re", "or", "rn", "au", "ur", "rh", "sr", "tc", "lt", "lo", "as", "fr", "nb", "yb", "if", "pb", "ge", "th", "pm", "rb", "sh", "co", "ga", "li", "ha", "hz", "no", "bi", "di", "hi", "qa", "pi", "os", "uh", "wm", "an", "me", "mo", "na", "la", "st", "er", "sc", "ne", "mn", "mi", "am", "ex", "pt", "io", "be", "fm", "ta", "tb", "ni", "mr", "pa", "he", "lr", "sq", "ye" }));

            //[["qa","ba","br","sr","sq"],["qa","ca","cm","sm","sq"],["qa","ca","co","so","sq"],["qa","ca","cr","sr","sq"],["qa","fa","fm","sm","sq"],["qa","fa","fr","sr","sq"],["qa","ga","go","so","sq"],["qa","ha","ho","so","sq"],["qa","la","lo","so","sq"],["qa","la","lr","sr","sq"],["qa","la","lt","st","sq"],["qa","ma","mb","sb","sq"],["qa","ma","mo","so","sq"],["qa","ma","mr","sr","sq"],["qa","ma","mt","st","sq"],["qa","na","nb","sb","sq"],["qa","na","no","so","sq"],["qa","pa","pb","sb","sq"],["qa","pa","ph","sh","sq"],["qa","pa","pm","sm","sq"],["qa","pa","po","so","sq"],["qa","pa","pt","st","sq"],["qa","ra","rb","sb","sq"],["qa","ra","rh","sh","sq"],["qa","ta","tc","sc","sq"],["qa","ta","th","sh","sq"],["qa","ta","tm","sm","sq"],["qa","ya","yb","sb","sq"],["qa","ya","yo","so","sq"]]
            //[["qa","ba","be","se","sq"],["qa","ba","bi","si","sq"],["qa","ba","br","sr","sq"],["qa","ca","cm","sm","sq"],["qa","ca","co","so","sq"],["qa","la","ln","sn","sq"],["qa","la","lt","st","sq"],["qa","ma","mb","sb","sq"],["qa","pa","ph","sh","sq"],["qa","ta","tc","sc","sq"],["qa","fa","fe","se","sq"],["qa","ga","ge","se","sq"],["qa","ha","he","se","sq"],["qa","la","le","se","sq"],["qa","ma","me","se","sq"],["qa","na","ne","se","sq"],["qa","ra","re","se","sq"],["qa","ya","ye","se","sq"],["qa","ca","ci","si","sq"],["qa","ha","hi","si","sq"],["qa","la","li","si","sq"],["qa","ma","mi","si","sq"],["qa","na","ni","si","sq"],["qa","pa","pi","si","sq"],["qa","ta","ti","si","sq"],["qa","ca","cr","sr","sq"],["qa","fa","fr","sr","sq"],["qa","la","lr","sr","sq"],["qa","ma","mr","sr","sq"],["qa","fa","fm","sm","sq"],["qa","pa","pm","sm","sq"],["qa","ta","tm","sm","sq"],["qa","ga","go","so","sq"],["qa","ha","ho","so","sq"],["qa","la","lo","so","sq"],["qa","ma","mo","so","sq"],["qa","na","no","so","sq"],["qa","pa","po","so","sq"],["qa","ta","to","so","sq"],["qa","ya","yo","so","sq"],["qa","ma","mn","sn","sq"],["qa","ra","rn","sn","sq"],["qa","ma","mt","st","sq"],["qa","pa","pt","st","sq"],["qa","na","nb","sb","sq"],["qa","pa","pb","sb","sq"],["qa","ra","rb","sb","sq"],["qa","ta","tb","sb","sq"],["qa","ya","yb","sb","sq"],["qa","ra","rh","sh","sq"],["qa","ta","th","sh","sq"]]

        }
    }
}