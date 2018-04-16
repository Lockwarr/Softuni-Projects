using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        int NumOfCommands = int.Parse(Console.ReadLine());
        var stack = new Stack<string>();
        stack.Push("");
        var text = new StringBuilder();
        for (int i = 0; i < NumOfCommands; i++)
        {
            string[] command = Console.ReadLine().Trim().Split();
            switch (command[0])
            {
                case "1":
                    stack.Push(text.ToString());
                    text.Append(command[1]);
                    
                    break;
                case "2":
                    stack.Push(text.ToString());
                    int length = int.Parse(command[1]);
                    text.Remove(text.Length - length, length);
                  
                    break;
                case "3":
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index-1]);
                    break;
                case "4":
                    text.Clear();
                    text.Append(stack.Pop());
                    break;
                default:
                    break;

            }
        }
    }
}
