﻿namespace HackerRank
{
    public static class Algorithms
    {
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