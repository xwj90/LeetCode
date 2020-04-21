/*
 * @lc app=leetcode id=648 lang=csharp
 *
 * [648] Replace Words
 */

// @lc code=start
public class Solution
{
    public string ReplaceWords(IList<string> dict, string sentence)
    {
        var inputs = sentence.Split();
        for (var i = 0; i < inputs.Length; i++)
        {
            foreach (var d in dict)//Trie is faster
            {
                if (inputs[i].StartsWith(d))
                {
                    inputs[i] = d;
                    break;
                }
            }
        }
        return string.Join(' ', inputs);
    }
}
// @lc code=end

