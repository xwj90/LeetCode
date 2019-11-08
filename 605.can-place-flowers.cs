/*
 * @lc app=leetcode id=605 lang=csharp
 *
 * [605] Can Place Flowers
 */
public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int i = 0, count = 0;
        while (i < flowerbed.Length)
        {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                count++;
            }
            i++;
        }
        return count >= n;
    }
}

