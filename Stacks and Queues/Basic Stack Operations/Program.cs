using System;
using System.Collections.Generic;
using System.Linq;


   public class Program
    {
        public static void Main(string[] args)
        {
        int[] numbers = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

        int N = numbers[0];
        int S = numbers[1];
        int X = numbers[2];
        var stack = new Stack<int>();
       
           int[] numbersToStack = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); 

        foreach(var number in numbersToStack)
        {
            stack.Push(number);
        }

        for(int i = 0; i < S; i++)
        {
            stack.Pop();
        }
        bool HasX = stack.Contains(X);
        if (HasX)
        {
            Console.WriteLine("true");
        }else
        {
            int min = 99999;
            if ((N - S) == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < N - S; i++)
                {
                    int var = numbersToStack[i];
                    if (var < min)
                    {
                        min = var;
                    }
                }
                Console.WriteLine(min);
            }
        }
     }
        
}
  

