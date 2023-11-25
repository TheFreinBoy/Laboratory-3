using System;

namespace laba3
{
    internal class Program
    {
        static bool IsFracIrreducible(int k, int a)
        {           
            return 1 == CalcGreatestCommonDivisor(k, a);
        }
        static void PrintAllFracs(int n)
        {
            for (int i = 1; i <= n; i++)
            {           
                for (int j = 1; j <= n; j++)
                {
                    if (i > j && IsFracIrreducible(j,i))
                    {
                        
                        Console.WriteLine($"{j}/{i}");
                        Console.WriteLine();
                    }
                }
            }
        }
        static int CalcGreatestCommonDivisor(int n, int m)
        {
            while (n != 0 && m != 0)
            {
                if (n > m)
                    n %= m;
                else
                    m %= n;
            }
            return n | m;
        }     
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            PrintAllFracs(N);
        }
    }
}