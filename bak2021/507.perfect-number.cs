public class Solution //i do not know how to do it.
{
    public bool CheckPerfectNumber(int num)
    {
        if (num <= 0) return false;
        var sum = 0;
        for (var i = 1; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
                if (i * i != num) {
                    sum += num / i;
                }
            }
        }
       return sum - num == num;
    }
}
// @lc code=end

