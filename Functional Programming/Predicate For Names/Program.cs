using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(' ').ToArray();
        Console.WriteLine(string.Join(Environment.NewLine, names.Where(n => n.Length<=length)));
    }
}

