public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;

        var d1 = 2;
        var d2 = 1;
        var sum = 0;
        for (var i = 3; i <= n; i++)
        {           
            sum = d1 + d2;
            d2 = d1;
            d1 = sum;
        }
        return sum;
    }
}

