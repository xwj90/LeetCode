public class Solution
{
    int missing(int idx, int[] nums)
    {
        return nums[idx] - nums[0] - idx;
    }
    public int MissingElement(int[] nums, int k)
    {
        var n = nums.Length;
        if (k > missing(n - 1, nums))
            return nums[n - 1] + k - missing(n - 1, nums);

        var left = 0;
        var right = n - 1;
        var pivot = 0;
        while (left != right)
        {
            pivot = left + (right - left) / 2;
            if (missing(pivot, nums) < k) left = pivot + 1;
            else right = pivot;
        }

        return nums[left - 1] + k - missing(left - 1, nums);

    }


    /*
        


        public int MissingElement(int[] nums, int k)
        {
            int n = nums.Length;
            // If kth missing number is larger than 
            // the last element of the array
            if (k > missing(n - 1, nums))
                return nums[n - 1] + k - missing(n - 1, nums);

            int idx = 1;
            // find idx such that 
            // missing(idx - 1) < k <= missing(idx)
            while (missing(idx, nums) < k) idx++;

            // kth missing number is greater than nums[idx - 1]
            // and less than nums[idx]
            return nums[idx - 1] + k - missing(idx - 1, nums);

        } */
}