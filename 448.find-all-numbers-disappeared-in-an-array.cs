/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 */

// @lc code=start
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
       var  ret = new List<int>();
        
        for(int i = 0; i < nums.Length; i++) {
            int val = Math.Abs(nums[i]) - 1;
            if(nums[val] > 0) {
                nums[val] = -nums[val];
            }
        }
        
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] > 0) {
                ret.Add(i+1);
            }
        }
        return ret;
    }
}
// @lc code=end

