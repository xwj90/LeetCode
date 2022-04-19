public class Solution
{
    public int LargestSumAfterKNegations(int[] nums, int k)
    {
        Array.Sort(nums); // change all negative number to positive

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0 && k > 0)
            {
                nums[i] = -nums[i];
                k--;
            }
        }

        Array.Sort(nums);// alway change the smallest number 

        if (k % 2 == 1)
            nums[0] = -nums[0];
        return nums.Sum();

    }
}

