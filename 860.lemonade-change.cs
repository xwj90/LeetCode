public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        var five = 0;
        var ten = 0;
        var twenty = 0;
        for (var i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                five++;
            }
            else if (bills[i] == 10)
            {
                if (--five < 0) return false;
                ten++;
            }
            else if (bills[i] == 20)
            {
                if (ten > 0 && five > 0)
                {
                    ten--; five--; twenty++;
                }
                else if (ten <= 0 && five >= 3)
                {
                    five -= 3; twenty++;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}
// @lc code=end
//[5,5,10,10,20]

