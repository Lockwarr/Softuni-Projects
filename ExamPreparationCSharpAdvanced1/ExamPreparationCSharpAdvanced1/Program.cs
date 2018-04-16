using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var index = 0;
        string pattern = @"\[[^\[\s]+<(\d+)REGEH(\d+)>[^\s\]]+?\]";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        string result = string.Empty;
        foreach (Match mat4 in matches)
        {
            var index1 = int.Parse(mat4.Groups[1].Value);
            var index2 = int.Parse(mat4.Groups[2].Value);
            index += index1;
            if (index >= input.Length)
            {
                var realindex = 0;
                while (index >= input.Length) { realindex = index -= input.Length - 1; }
                result += input[realindex];
            }
            else
            {
                result += input[index];
            }
            index += index2;
            if (index >= input.Length)
            {
                var realindex = 0;
                while (index >= input.Length) {realindex = index -= input.Length - 1; }
                result += input[realindex];
            }
            else
            {
                result += input[index];
            }
        }

        Console.WriteLine(result);
    }
}

