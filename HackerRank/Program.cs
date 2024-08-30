namespace HackerRank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hacker Rank");
        Console.WriteLine(Algorithms.jumpingOnClouds([0, 0, 1, 0], 2));
        Console.WriteLine(Algorithms.jumpingOnClouds([1, 1, 1, 0, 1, 1, 0, 0, 0, 0], 3));
    }
}