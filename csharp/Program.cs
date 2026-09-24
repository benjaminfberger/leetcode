namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            Console.WriteLine(s.SmallestIndex(new int[] { 1, 2, 3 }));
        }
    }
}
