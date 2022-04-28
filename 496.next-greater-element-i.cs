public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {

        var res = new int[nums1.Length];
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums1.Length; i++)
        {
            res[i] = -1;
            dict[nums1[i]] = i;
        }

        var stack = new Stack<int>();
        stack.Push(nums2[0]);

        for (var i = 1; i < nums2.Length; i++)
        {
            while (stack.Any() && stack.Peek() < nums2[i])
            {
                var v = stack.Pop();
                if (dict.ContainsKey(v))
                    res[dict[v]] = nums2[i];
            }
            stack.Push(nums2[i]);
        }
        return res;
    }
}
// @lc code=end

