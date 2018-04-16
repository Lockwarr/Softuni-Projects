using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
 
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Trim()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int divider = int.Parse(Console.ReadLine());
        Func<int,bool> predicate = n => n % divider != 0;
        
        var result = numbers.Reverse().Where(predicate);
        Console.WriteLine(string.Join(" ", result));
    }
}

