namespace HackerRank;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hacker Rank");

        plusMinus([1,2,3]);
    }

    public static void plusMinus(List<int> arr)
    {
        decimal positives = 0;
        decimal negatives = 0;
        decimal zeros = 0;

        foreach (int item in arr)
        {
            if (item == 0)
            {
                zeros++;
                continue;
            }
            else if (item > 0)
                positives++;
            else
                negatives++;
        }
        Console.WriteLine(positives / arr.Count);
        Console.WriteLine(negatives / arr.Count);
        Console.WriteLine(zeros / arr.Count);
    }
}