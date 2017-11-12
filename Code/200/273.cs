using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    String[] LESS_THAN_20 = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    String[] TENS = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    String[] THOUSANDS = { "", "Thousand", "Million", "Billion" };
    public string NumberToWords(int num)
    {
        if(num==0)
            return "Zero";
        var v = num;
        var r = "";
        var i = 0;
        while (v > 0)
        {
            var t = v % 1000;
            if (t != 0)
                r = NumberToWords_GetWord(t) + THOUSANDS[i] + " " + r;
            v = v / 1000;
            i++;
        }
        return r.Trim();
    }
    string NumberToWords_GetWord(int number)
    {
        if (number == 0) return "";
        else if (number < 20) return LESS_THAN_20[number] + " ";
        else if (number < 100) return TENS[number / 10] + " " + NumberToWords_GetWord(number % 10);
        else return LESS_THAN_20[number / 100] + " Hundred " + NumberToWords_GetWord(number % 100);

    }
}