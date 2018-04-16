using System;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {
        int min = 999999999 ;
        string input = Console.ReadLine();
        Func<string, int> parser = n => int.Parse(n);
        int[] numbers = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();
       for(int i = 0; i < numbers.Length-1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                if (min > numbers[i])
                {

                    min = numbers[i];
                }
            }
            else
            {
                if (min > numbers[i + 1])
                {
                    min = numbers[i + 1];
                }
            }
        }
       if(numbers.Length == 1)
        {
            min = numbers[0];
        }
        Console.WriteLine(min);
        }
    }

