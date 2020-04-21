public class Solution
{
    public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
    {

        (int x, int y)[] p = { (p1[0], p1[1]), (p2[0], p2[1]), (p3[0], p3[1]), (p4[0], p4[1]) };
        Array.Sort(p);
        return dist(p[0], p[1]) != 0
        && dist(p[0], p[1]) == dist(p[1], p[3]) //side
        && dist(p[1], p[3]) == dist(p[3], p[2])
        && dist(p[3], p[2]) == dist(p[2], p[0])
        && dist(p[0], p[3]) == dist(p[1], p[2]); //diagonal 
    }

    public double dist((int x, int y) p1, (int x, int y) p2)
    {
        return Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2);
    }
}
// @lc code=end

