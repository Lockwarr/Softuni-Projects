using System;
using System.Collections.Generic;
using System.Linq;

  public class Program
    {
       public static void Main()
        {
        int[] numbers = Console.ReadLine()
            .Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var stack = new Stack<int>();
        foreach(var number in numbers)
        {
            stack.Push(number);
        }
       
            Console.WriteLine(string.Join(" ", stack));
       
        }
    }

