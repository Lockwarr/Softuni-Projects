using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var stack = new Stack<int>();
        var maxStack = new Stack<int>();

        maxStack.Push(int.MinValue);

        int max = 0;
        for (int i = 0; i < N; i++)
        {
            int[] command = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            if (command[0] == 1)
            {
                stack.Push(command[1]);
                if (command[1] >= maxStack.Peek())
                {
                    maxStack.Push(command[1]);
                }
            }
            else if (command[0] == 2)
            {
                var popElement = stack.Pop();
                if(maxStack.Peek()== popElement)
                {
                    maxStack.Pop();
                }
            }
            else if(command[0]== 3)
            {
                Console.WriteLine(maxStack.Peek());
            }
        }
    }
}

