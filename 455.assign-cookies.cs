public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        var j = 0;
        var content = 0;
        for (var i = 0; i < g.Length; i++)
        {
            while (j < s.Length && g[i] > s[j])      //find next available cookie      
                j++;
            if (j >= s.Length) //out of cookies
                break;
            content++;
            j++;

        }
        return content;
    }
}

