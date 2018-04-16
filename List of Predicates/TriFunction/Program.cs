using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;
        string[] names = Console.ReadLine().Trim().Split(' ').ToArray();
        Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray().Select(ch => (int)ch).Sum() >= num;
        Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr.FirstOrDefault(str => func(str, num));

        var result = firstValidName(names, numberN, isValidWord);
        Console.WriteLine(result);
    }
}

