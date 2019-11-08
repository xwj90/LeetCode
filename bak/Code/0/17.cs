using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    Dictionary<string, List<string>> letterList = new Dictionary<string, List<string>>();

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrWhiteSpace(digits))
            return new List<string>();
        letterList["2"] = new List<string>() { "a", "b", "c" };
        letterList["3"] = new List<string>() { "d", "e", "f" };
        letterList["4"] = new List<string>() { "g", "h", "i" };
        letterList["5"] = new List<string>() { "j", "k", "l" };
        letterList["6"] = new List<string>() { "m", "n", "o" };
        letterList["7"] = new List<string>() { "p", "q", "r", "s" };
        letterList["8"] = new List<string>() { "t", "u", "v" };
        letterList["9"] = new List<string>() { "w", "x", "y", "z" };
        return FindLetterCombinations(digits);
    }
    public List<string> FindLetterCombinations(string digits)
    {
        if (digits.Length == 1)
            return letterList[digits];

        var first = digits.Substring(0, 1);
        var follow = digits.Substring(1, digits.Length - 1);
        List<string> s = new List<string>();
        foreach (var item in letterList[first])
        {
            var list = FindLetterCombinations(follow);
            foreach (var item2 in list)
                s.Add(item + item2);
        }
        letterList[digits] = s;
        return s;

    }
}