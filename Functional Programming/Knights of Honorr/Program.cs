using System;
using System.Linq;

class Program
{
    public static void Print(string[] array)
    {
      
        foreach(var stri in array)
        {
            Console.WriteLine("Sir " + stri);
        }
    }
    public static void Main(string[] args)
    {
        string[] imena = Console.ReadLine().Split(' ');
        Action<string[]> action = Print;
        action(imena);

        Console.WriteLine();
    }
}
