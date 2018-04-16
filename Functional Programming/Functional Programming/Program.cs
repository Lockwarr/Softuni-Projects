using System;
using System.Linq;

class Program
    {
    public static void Print(string[] array)
    {
        Console.WriteLine(string.Join(Environment.NewLine, array));
    }
        public static void Main(string[] args)
        {
        string[] imena = Console.ReadLine().Split(' ');
        Action<string[]> action = Print;
        action(imena);

        Console.WriteLine();
        }
    }
