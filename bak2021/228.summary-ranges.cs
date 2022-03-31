/*
 * @lc app=leetcode id=228 lang=csharp
 *
 * [228] Summary Ranges
 */
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        int? previousNumber = null;
        List<List<int>> list = new List<List<int>>();
        List<int> data = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!previousNumber.HasValue)
            {
                data = new List<int>();
                data.Add(nums[i]);
            }
            else if ((previousNumber + 1) == nums[i])
            {
                data.Add(nums[i]);
            }
            else
            {
                if (data.Count > 1)
                {
                    list.Add(new List<int>() { data[0], data[data.Count - 1] });
                }
                else if (data.Count == 1)
                {
                    list.Add(data.Take(1).ToList());
                }

                data = new List<int>();
                data.Add(nums[i]);
            }
            previousNumber = nums[i];
        }

        if (data.Count > 1)
        {
            list.Add(new List<int>() { data[0], data[data.Count - 1] });
        }
        else if (data.Count == 1)
        {
            list.Add(data.Take(1).ToList());
        }


        return list.Select(p => string.Join("->", p)).ToList();
    }
}

