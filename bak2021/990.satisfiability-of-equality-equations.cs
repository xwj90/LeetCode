/*
 * @lc app=leetcode id=990 lang=csharp
 *
 * [990] Satisfiability of Equality Equations
 */
public class Solution
{
    public bool EquationsPossible(string[] equations)
    {
        var dict = new Dictionary<char, char>();
        foreach (var e in equations)
        {
            if (!dict.ContainsKey(e[0])) dict[e[0]] = e[0];
            if (!dict.ContainsKey(e[3])) dict[e[3]] = e[3];
        }

        foreach (var e in equations)
        {
            if (e[1] == '=')
            {
                var top0 = FindTop(dict, e[0]);
                var top1 = FindTop(dict, e[3]);
                if (top0 != top1)
                {
                    dict[top0] = top1;
                }
            }
        }
        foreach (var e in equations)
        {
            if (e[1] == '!')
            {
                var top0 = FindTop(dict, e[0]);
                var top1 = FindTop(dict, e[3]);
                if (top0 == top1)
                    return false;
            }
        }
        return true;
    }
    public char FindTop(Dictionary<char, char> dict, char input)
    {
        if (dict[input] == input)
            return input;
        else
            return FindTop(dict, dict[input]);
    }
}

