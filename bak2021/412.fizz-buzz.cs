/*
 * @lc app=leetcode id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */
public class Solution
{
    public IList<string> FizzBuzz(int n)
    {

        var res = new List<string>();
        for (var i = 1; i <= n; i++)
        {
            var d3 = i % 3;
            var d5 = i % 5;
            if (d3 == 0 && d5 == 0)
            {
                res.Add("FizzBuzz");
            }
            else if (d3 == 0)
            {
                res.Add("Fizz");
            }
            else if (d5 == 0)
            {
                res.Add("Buzz");
            }
            else
            {
                res.Add(i.ToString());
            }
        }
        return res;

    }
}

