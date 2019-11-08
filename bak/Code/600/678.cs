using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    /// <summary>
    /// LeetCode 678 Valid Parenthesis String
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool CheckValidString(string s)
    {
        return CheckValidString_Go(s, 0, 0);
    }
    bool CheckValidString_Go(string s, int start, int count)
    {
        if (count < 0) return false;
        for (int i = start; i < s.Length; i++)
        {
            if (s[i] == '(')
                count++;
            else if (s[i] == ')')
            {
                if (count <= 0) return false;
                count--;
            }
            else if (s[i] == '*')
            {
                return CheckValidString_Go(s, i + 1, count) || CheckValidString_Go(s, i + 1, count - 1) || CheckValidString_Go(s, i + 1, count + 1);
            }
        }
        return count == 0;
    }
    /*
    public bool CheckValidString(string s)
    {
        int low = 0;
        int high = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i]=='(')
            {
                low++;
                high++;
            }
            else if (s[i]==')')
            {
                if (low > 0)
                    low--;
                high--;
            }
            else
            {
                if (low > 0)
                    low--;
                high++;
            }
            if (high < 0)
                return false;
        }
        return low == 0;
    }
     */
}