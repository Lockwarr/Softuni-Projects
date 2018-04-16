using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
    public static Queue<int> EvensOrOdds(int lowerBound,int upperBound,Predicate<int> filter)
    {
        var numbers = new Queue<int>();
        for(int i = lowerBound; i <= upperBound; i++)
        {
            if (filter(i))
            {
                numbers.Enqueue(i);
            }
        }
        return numbers;

    }
        static void Main(string[] args)
        {
        int[] boundaries = Console.ReadLine()
            .Trim()
            .Split()
            .Select(int.Parse)
            .ToArray();
        string oddOrEven = Console.ReadLine().Trim().ToLower();
        var start = boundaries[0];
        var end = boundaries[1];
        Predicate<int> predicate;
        switch (oddOrEven)
        {
            case "odd":
                predicate = n => n % 2 != 0;
                break;
            case "even":
                predicate = n => n % 2 == 0;
                break;
            default:
                predicate = null;
                break;
        }
        var result = EvensOrOdds(start, end, predicate);
        Console.WriteLine(string.Join(" ", result));

        }
    }

