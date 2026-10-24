namespace csharp._2409;

public class Solution
{
    private static int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(1) and time complexity of O(1)
    /// </summary>
    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob) 
    {
        int arriveA = ToDayOfYear(arriveAlice);
        int leaveA  = ToDayOfYear(leaveAlice);
        int arriveB = ToDayOfYear(arriveBob);
        int leaveB  = ToDayOfYear(leaveBob);

        int startOverlap = Math.Max(arriveA, arriveB);
        int endOverlap   = Math.Min(leaveA, leaveB);

        return Math.Max(0, endOverlap - startOverlap + 1);
    }
    private int ToDayOfYear(string mmDd) 
    {
        int month = (mmDd[0] - '0') * 10 + (mmDd[1] - '0');
        int day   = (mmDd[3] - '0') * 10 + (mmDd[4] - '0');

        int totalDays = day;
        for (int m = 1; m < month; m++)
            totalDays += daysInMonth[m - 1];
        return totalDays;
    }
}