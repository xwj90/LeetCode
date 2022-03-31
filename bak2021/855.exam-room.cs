/*
 * @lc app=leetcode id=855 lang=csharp
 *
 * [855] Exam Room
 */

// @lc code=start
public class ExamRoom
{
    private List<int> availableSeats = new List<int>();
     
    public ExamRoom(int N)
    {

    }

    public int Seat()
    {
        if (!seats.Any())
        {
            seats.Add(0);
            return 0;
        }
    }

    public void Leave(int p)
    {
        seats.RemoveAt(p);
    }
}

/**
 * Your ExamRoom object will be instantiated and called as such:
 * ExamRoom obj = new ExamRoom(N);
 * int param_1 = obj.Seat();
 * obj.Leave(p);
 */
// @lc code=end

