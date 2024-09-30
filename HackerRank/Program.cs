namespace HackerRank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hacker Rank");

        var lista = Algorithms.acmTeam(["10101","11110","00010"]);

        Console.WriteLine(string.Join(",", lista));
    }
}