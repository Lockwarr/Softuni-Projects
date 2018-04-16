using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int EndRange = int.Parse(Console.ReadLine());
        int[] divisors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool flag = true;
        for (int z = 1; z <= EndRange; z++)
        {
            flag = true;
            for (int i = 0; i < divisors.Length; i++)
            {
                Predicate<int> filter = n => n % divisors[i] == 0;
                if (!filter(z))
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.Write(z+" ");
            }
        }
    }
}
