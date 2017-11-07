using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return new int[0];
        List<int> q = new List<int>();
        int[] result = new int[nums.Length - k + 1];
        int id = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (q.Count > 0 && q[0] < i + 1 - k)
                q.RemoveAt(0);

            while (q.Count > 0 && nums[q[q.Count - 1]] < nums[i])
                q.RemoveAt(q.Count - 1);

            q.Add(i);
            if (i >= k - 1)
                result[id++] = nums[q.First()];
        }
        return result;
    }
}