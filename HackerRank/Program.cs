namespace HackerRank;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hacker Rank");

        
    }
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        int contador = 0;
        int punto1 = 0;
        int punto2 = 0;

        int xMayor = 0;
        int vMayor = 0;

        int xMenor = 0;
        int vMenor = 0;

        if (x2 > x1)
        {
            xMayor = x2;
            vMayor = v2;
            xMenor = x1;
            vMenor = v1;
        }
        else
        {
            xMayor = x1;
            vMayor = v1;
            xMenor = x2;
            vMenor = v2;
        }

        while (true)
        {
            punto1 = xMayor + vMayor * contador;
            punto2 = xMenor + vMenor * contador;

            if (punto1 == punto2)
                return "YES";

            if (punto1 > punto2 && vMenor <= vMayor || punto1 < punto2 && vMayor <= vMenor)
                break;

            contador++;
        }
        return "NO";
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