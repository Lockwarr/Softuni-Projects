using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        bool isSolution = true;
        int count = 0;
        char[] input = Console.ReadLine().ToCharArray();

        var stack = new Stack<char>();
        var queue = new Queue<char>();
        foreach (var element in input)
        {
            count++;
            stack.Push(element);
            queue.Enqueue(element);

        }
        for (int i = 0; i < count / 2; i++)
        {
            if ((stack.Peek() == '}' && queue.Peek() == '{') 
                || (stack.Peek() == ')' && queue.Peek() == '(')
                || (stack.Peek() == ']' && queue.Peek() == '[')
                || (stack.Peek() == ' ' && queue.Peek() == ' '))
        {

                stack.Pop();
                queue.Dequeue();
            }else
            {
                isSolution = false;
            }
        }
        if (count % 2 != 0)
        {
            Console.WriteLine("NO");
            Environment.Exit(0);
        }
        if (isSolution)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
