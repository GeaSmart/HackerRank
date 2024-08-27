namespace HackerRank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hacker Rank");
        List<int> heights = [1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5];
        Console.WriteLine(Algorithms.designerPdfViewer(heights,"abc"));
    }
}