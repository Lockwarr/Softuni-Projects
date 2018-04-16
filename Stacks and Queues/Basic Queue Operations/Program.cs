using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        int[] commands = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
        var queue = new Queue<int>();

        int[] elements = Console.ReadLine()
             .Trim()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
        for (int i = 0; i < commands[0]; i++)
        {
            queue.Enqueue(elements[i]);
        }
        for (int i = 0; i < commands[1]; i++)
        {
            if (queue.Count != 0)
            {
                queue.Dequeue();
            }
        }
        if (queue.Count != 0)
        {


            if (queue.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
