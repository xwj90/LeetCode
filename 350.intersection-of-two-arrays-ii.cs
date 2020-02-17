/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */

// @lc code=start
public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var dict1 = new Dictionary<int, int>();
        var dict2 = new Dictionary<int, int>();
        var res=new List<int>();
        foreach (var n in nums1)
        {
            if (!dict1.ContainsKey(n)) dict1[n] = 0;
            dict1[n]++;
        }
        foreach (var n in nums2)
        {
            if (!dict2.ContainsKey(n)) dict2[n] = 0;
            dict2[n]++;
        }
        foreach(var pair in dict1)
        {
            if(dict2.ContainsKey(pair.Key))
            {
                var count =Math.Min(pair.Value,dict2[pair.Key]);
                for(var i =0;i<count ;i++)
                {
                    res.Add(pair.Key);
                }
            }
        }
        return res.ToArray();

    }
}
// @lc code=end

