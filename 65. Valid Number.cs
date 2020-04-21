public class Solution
{
    public bool IsNumber(string s)
    {
        return decimal.TryParse(s, out var o);
        // var ss = s.Trim().Split('e');
        // if (ss.Length > 2) return false;
        // foreach (var str in ss)
        // {
        //     var pointSeen = false;
        //     var numberBefore = false;
        //     for (var i = 0; i < str.Length; i++)
        //     {
        //         if (str[i] >= '0' && str[i] <= '9')
        //         {
        //             numberBefore = true;
        //         }
        //         else if (str[i] == '.')
        //         {
        //             if (pointSeen) return false;
        //             pointSeen = true;
        //         }
        //         else if (str[i] == '-' || str[i] == '+')
        //         {
        //             if (i != 0) return false;
        //         }
        //         else
        //         {
        //             return false;
        //         }
        //     }
        //     if (!numberBefore) return false;

        // }
        // return true;
    }
}