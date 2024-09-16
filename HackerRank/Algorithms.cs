namespace HackerRank
{
    public static class Algorithms
    {
        public static string appendAndDelete(string s, string t, int k)//not submitted
        {
            char[] origin = s.ToCharArray();
            char[] destination = t.ToCharArray();
            int counterRight = 0;

            for (int i = 0; i < origin.Length; i++)
            {
                if (i > destination.Length - 1)
                    break;

                if (origin[i].Equals(destination[i]))
                    counterRight++;
                else
                    break;
            }
            int charsToDelete = origin.Length == counterRight ? origin.Length + 1 : origin.Length - counterRight;
            int charsToAdd = origin.Length == counterRight ? destination.Length : destination.Length - counterRight;
            Console.WriteLine($"delete:{charsToDelete} add:{charsToAdd}");
            return charsToDelete + charsToAdd == k ? "Yes" : "No";
        }
        public static int findDigits(int n)
        {
            var array = n.ToString().ToCharArray();
            int response = 0;

            foreach (var i in array)
            {
                int value = int.Parse(i.ToString());
                if (value == 0) continue;
                if (n % value == 0)
                    response++;
            }
            return response;
        }
        public static int jumpingOnClouds(int[] c, int k)
        {
            int index = 0;
            int points = 100;
            bool isExit = false;

            while (true)
            {
                index += k;
                if (index > c.Length - 1)
                {
                    index = index % c.Length;
                    isExit = true;
                }
                int value = c[index];

                if (value == 1)
                    points -= 2;

                points--;
                if (index == 0 && isExit) break;
            }
            return points;
        }
        public static List<int> permutationEquation(List<int> p)
        {
            int contador = 1;
            List<int> result = new List<int>();

            while (contador <= p.Count)
            {
                int index = 0;
                foreach (int value in p)
                {
                    int x = p[index];
                    int y = p[x - 1];
                    int z = p[y - 1];
                    if (z == contador)
                        result.Add(value);
                    index++;
                }
                contador++;
            }
            return result;
        }
        public static int saveThePrisoner(int n, int m, int s)
        {
            int resto = m % n;
            if (resto == 0 && m > 0)
                return s - 1 == 0 ? n : s - 1;
            return resto > (n - s) + 1 ? resto - (n - s) - 1 : s + resto - 1;
        }
        public static int viralAdvertising(int n)
        {
            int shared = 5;
            int accumulative = 0;
            for (int i = 1; i <= n; i++)
            {
                int liked = (int)Math.Floor((decimal)shared / 2);
                accumulative += liked;
                shared = liked * 3;
            }
            return accumulative;
        }
        public static int beautifulDays(int i, int j, int k)
        {
            int beautifulDays = 0;
            for (int x = i; x <= j; x++)
            {
                //Alternative using Chars
                //string reverse = "";
                //int reverseNumber = 0;
                //char[] numbers = x.ToString().ToCharArray();
                //for (int y = numbers.Length - 1; y >= 0; y--)
                //{
                //    reverse += numbers[y];
                //}
                //reverseNumber = Convert.ToInt32(reverse);

                int number = x;
                int reverseNumber = 0;

                while (number != 0)
                {
                    int digit = number % 10;
                    reverseNumber = reverseNumber * 10 + digit;
                    number /= 10;
                }

                if (Math.Abs(x - reverseNumber) % k == 0)
                    beautifulDays++;
            }
            return beautifulDays;
        }
        public static string angryProfessor(int k, List<int> a)
        {
            int counterOnTime = 0;
            foreach (var item in a)
            {
                if (item <= 0)
                    counterOnTime++;
            }
            return counterOnTime >= k ? "NO" : "YES";
        }
        public static int utopianTree(int n)
        {
            int height = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    height++;
                else
                    height *= 2;
            }
            return height;
        }
        public static int designerPdfViewer(List<int> h, string word)
        {
            int max = 0;
            int index = 0;
            char[] chars = word.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                index = (int)chars[i] - 97;
                if (h[index] > max)
                    max = h[index];
            }
            return chars.Length * max;
        }
        public static int hurdleRace(int k, List<int> height)
        {
            //Using MaxBy Linq alternative
            //return height.Select(x => { var max = height.MaxBy(y => y); return max > k ? max - k : 0; }).First();

            int max = 0;
            foreach (var item in height)
            {
                if (item > max)
                    max = item;
            }
            return max > k ? max - k : 0;
        }
        public static int pickingNumbers(List<int> a)
        {
            int counter = 0;
            int maxLength = 0;
            HashSet<int> set = new HashSet<int>();
            a.Sort();
            a.ForEach(x => set.Add(x));

            foreach (int x in set)
            {
                counter = 0;
                int previous = x - 1;
                foreach (var item in a)
                {
                    if (item == previous || item == x)
                        counter++;
                }
                if (counter > maxLength)
                    maxLength = counter;
            }
            return maxLength;
        }
        public static string catAndMouse(int x, int y, int z)
        {
            int distanceCatA = Math.Abs(z - x);
            int distanceCatB = Math.Abs(z - y);
            if (distanceCatA == distanceCatB)
                return "Mouse C";
            return distanceCatA < distanceCatB ? "Cat A" : "Cat B";
        }
        public static int countingValleys(int steps, string path)
        {
            int counterD = 0;
            int counterU = 0;
            int counterValleys = 0;
            bool valleyBegin = false;

            foreach (var letra in path)
            {
                if (letra == 'D')
                {
                    if (counterU == 0)
                        valleyBegin = true;
                    counterD++;
                }
                else
                {
                    counterU++;
                    if (counterD == 0)
                        valleyBegin = false;
                }

                if (counterD == counterU)
                {
                    counterD = 0;
                    counterU = 0;
                    if (valleyBegin)
                    {
                        counterValleys++;
                        valleyBegin = false;
                    }
                }
            }
            return counterValleys;
        }
        public static string dayOfProgrammer(int year)
        {
            int diasFeb = 28;

            if (year >= 1700 && year <= 1917 && year % 4 == 0)
                diasFeb = 29;
            else if (year == 1918)
                diasFeb = 15;
            else if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                diasFeb = 29;

            List<int> diasPorMes = new List<int>();
            diasPorMes.Add(31);
            diasPorMes.Add(diasFeb);//feb
            diasPorMes.Add(31);
            diasPorMes.Add(30);//apr
            diasPorMes.Add(31);
            diasPorMes.Add(30);//jun
            diasPorMes.Add(31);
            diasPorMes.Add(31);//aug
            diasPorMes.Add(30);
            diasPorMes.Add(31);//oct
            diasPorMes.Add(30);
            diasPorMes.Add(31);//dec

            int numeroDia = 256;
            int sumaDias = 0;
            int contadorMesesCompletos = 0;
            int diasAcumulados = 0;

            foreach (var dias in diasPorMes)
            {
                sumaDias += dias;
                if (sumaDias <= numeroDia)
                    contadorMesesCompletos++;
            }

            for (int i = 0; i < contadorMesesCompletos; i++)
                diasAcumulados += diasPorMes[i];

            int diasRestantes = numeroDia - diasAcumulados;
            return $"{diasRestantes}.{contadorMesesCompletos + 1:00}.{year}";
        }
        public static int migratoryBirds(List<int> arr)
        {
            HashSet<int> set = new HashSet<int>();

            int counter = 0;
            int max_reps = 0;
            int max_value = 0;

            arr.Sort();
            arr.ForEach(x => set.Add(x));

            foreach (var x in set)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (x == arr[i])
                    {
                        counter++;
                        if (counter > max_reps)
                        {
                            max_reps = counter;
                            max_value = x;
                        }
                    }
                }
                counter = 0;
            }
            return max_value;
        }
        public static void getTotalX(List<int> a, List<int> b)
        {
            List<int> response = new();
            a.Sort();
            b.Sort();
            int min = a[0] <= b[0] ? a[0] : b[0];
            int max = a.Last() >= b.Last() ? a.Last() : b.Last();

            for (int i = min; i <= max; i++)
            {
                bool flag = true;
                foreach (var item in a)
                {
                    if (i % item == 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                foreach (var item in b)
                {
                    if (item % i == 0 && flag)
                    {
                        response.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(",", a));
            Console.WriteLine(string.Join(",", b));
            Console.WriteLine($"min {min}, max {max}");
            Console.WriteLine(string.Join(",", response));
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
}
