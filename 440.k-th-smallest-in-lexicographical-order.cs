public class Solution
{
    public int FindKthNumber(int n, int k)
    {
        var current = 1;
        k = k - 1;
        while (k > 0)
        {
            //move from (n)xxxxx to (n+1)xxxx
            var steps = calSteps(n, current, current + 1);
            if (steps <= k)
            {
                current += 1; //1->2  2->3 ....
                k -= steps;
            }
            else
            {
                current *= 10; //if it is in this group and go deeper.
                k -= 1; //layer is one step , consider 1-> 10
            }
        }
        return current;
    }
    public int calSteps(int n, long n1, long n2)
    {
        long steps = 0;
        while (n1 <= n)
        {
            steps += Math.Min(n + 1, n2) - n1;
            n1 *= 10;
            n2 *= 10;
        }
        return (int)steps;
    }
}
// @lc code=end

