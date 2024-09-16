namespace HackerRank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hacker Rank");

        Console.WriteLine(string.Join(",", Algorithms.cutTheSticks([5, 4, 4, 2, 2, 8])));
    }
}