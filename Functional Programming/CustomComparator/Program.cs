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
        var odd = new List<int>();
        var even = new List<int>();
        foreach(var num in numbers)
        {
            if(num%2 == 0)
            {
                even.Add(num);
            }
            else
            {
                odd.Add(num);
            }
        }
        odd.Sort();
        even.Sort();
        Console.WriteLine(string.Join(" ", even.ToArray()) +" " + string.Join(" ", odd.ToArray()));


    }
}
