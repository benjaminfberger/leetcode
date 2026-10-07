namespace csharp._0933;

public class Solution
{
    Queue<int> q;
    public Solution() 
    {
        q = new Queue<int>();
    }
    /// <summary>
    /// Beats 95.11% of submissions with time complexity of O(1) and space complexity of O(1)
    /// </summary>
    public int Ping(int t) 
    {
        q.Enqueue(t);

        while (q.Peek() < t - 3000)
            q.Dequeue();
        
        return q.Count;
    }
}