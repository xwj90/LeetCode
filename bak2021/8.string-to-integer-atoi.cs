public class Solution
{
    public int MyAtoi(string str)
    {
        str = str.Trim();
        long sign = 1;
        long res = 0;
        bool first = true;
        for (var i = 0; i < str.Length; i++)
        {
            if (i == 0 && str[i] == '-')
            {
                sign = -1;
            }
            else if (i == 0 && str[i] == '+')
            {
                sign = 1;
            }
            else if ((str[i] - '0') >= 0 && (str[i] - '0') <= 9)
            {
                res = res * 10 + (int)(str[i] - '0');   
                if (res -int.MaxValue >1) //early stop
                     break;
            }
            else
            {
                break;
            }
        }
        res =res * sign;
        
        if (res > int.MaxValue)
            return int.MaxValue;
        if (res < int.MinValue)
            return int.MinValue;

        return Convert.ToInt32(res);
    }
}