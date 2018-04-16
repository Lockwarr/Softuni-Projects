using System;
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
        string command = Console.ReadLine();
        while(command != "end")

        {
            switch (command)
            {
                case "add":
                 for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] += 1;
                    }
                    break;
                case "subtract":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                    break;
                case "multiply":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] *= 2;
                    }
                    break;
                case "print":
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                default:
                    Console.WriteLine("Wrong command!");
                    break;
            }

            command = Console.ReadLine();
        }
    }
}
