public class Solution
{
    public bool IsMatch(string s, string p)
    {
        if (s == null || p == null) return false;
        var dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;

        // check  a*b*a*.* pattern
        for (var i = 0; i < p.Length; i++)
        {
            if (p[i] == '*' && dp[0, i - 1]) dp[0, i + 1] = true;
        }

        for (var i = 1; i <= s.Length; i++)
        {
            for (var j = 1; j <= p.Length; j++)
            {
                var currentS = s[i - 1];
                var currentP = p[j - 1];
                if (currentP == '.' || currentP == currentS)
                    dp[i, j] = dp[i - 1, j - 1];
                else if (currentP == '*')
                {
                    var previousP = p[j - 2];
                    if (previousP != currentS && previousP != '.')
                        dp[i, j] = dp[i, j - 2]; //can't use .* or a* pattern and so that we have consider .*=="" 
                    else
                        dp[i, j] = dp[i, j - 2] || dp[i - 1, j - 2] || dp[i - 1, j]; // a*=="" or a*=="a"  or a*=="aa..."
                }
            }
        }
        return dp[s.Length, p.Length];
    }
}