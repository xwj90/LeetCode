
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 == str2 + str1)
        {
            return str1.Substring(0, GCD(str1.Length, str2.Length));
        }

        return "";
    }
    int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
// @lc code=end

