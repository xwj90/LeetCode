public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        if (num < 2) return true;

        long left = 2;
        long right = num / 2;
        while (left <= right)  // we need to check last value because we move left+1 and right-1 
        {
            var mid = left + (right - left) / 2;
            var pw = mid * mid;
            if (pw < num) left = mid + 1;
            else if (pw > num) right = mid - 1;
            else return true;
        }
        return false;

    }
}
// @lc code=end

