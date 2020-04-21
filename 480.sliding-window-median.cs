public class Solution
{
    public double[] MedianSlidingWindow(int[] nums, int k)
    {
        var res = new List<double>();
        // use sorted list to ensure all elements in current windows are in ascending order.
        var sl = new SortedList<long, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            sl.Add(GetId(i, nums), nums[i]);

            //remove first element to ensure only k element in current windows;
            if (sl.Count > k)
            {
                sl.Remove(GetId(i - k, nums));
            }

            //get median
            if (sl.Count == k)
            {
                if (k % 2 == 0) res.Add((sl[sl.Keys[k / 2 - 1]] / 2.0 + sl[sl.Keys[k / 2]] / 2.0));
                else res.Add(sl[sl.Keys[k / 2]]);
            }
        }

        return res.ToArray();
    }

    public long GetId(int i, int[] nums)
    {
        //sorted list does not allow duplicated keys
        //use value*int.MaxValue+index (or  value*Length+index) could make distinct value because i is distinct
        return Convert.ToInt64(nums[i]) * nums.Length + i;
    }
}


