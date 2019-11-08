/*
 * @lc app=leetcode id=722 lang=csharp
 *
 * [722] Remove Comments
 */
public class Solution
{
    public IList<string> RemoveComments(string[] source)
    {
        bool inCommentBlock = false;

        List<string> list = new List<string>();
        for (int i = 0; i < source.Length; i++)
        {
            if (!source[i].Trim().StartsWith("//"))
            {
                list.Add(source[i]);
            }
        }

        var str = string.Join("\r", list);
        List<char> chars = new List<char>();
        List<string> results = new List<string>();
        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] == '\r')
            {
                results.Add(new string(chars.ToArray()));
                chars.Clear();
            }
            else if (!inCommentBlock)
            {
                if (str[i] == '/' && i + 1 < str.Length && str[i + 1] == '*')
                {
                    inCommentBlock = true;
                    i++;
                }
                else
                {
                    chars.Add(str[i]);
                }
            }
            else if (inCommentBlock)
            {
                if (str[i] == '*' && i + 1 < str.Length && str[i + 1] == '/')
                {
                    inCommentBlock = false;
                    i++;
                }
            }
        }



        return results;

    }
}

