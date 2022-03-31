public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var res = new List<int>();
        var carry = 0;

        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        var newNumber = new int[digits.Length + 1];
        newNumber[0] = 1;
        return newNumber;

    }
}
// @lc code=end

