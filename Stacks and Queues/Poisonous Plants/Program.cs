using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    public static void Main(string[] args)
    {
        int NumberOfPlants = int.Parse(Console.ReadLine());
        var plants = new StringBuilder();
        var days = new int[NumberOfPlants];
        var indexes = new Stack<int>();
        int[] PlantsAlive = Console.ReadLine()
             .Trim()
             .Split()
             .Select(int.Parse)
             .ToArray();

        for (int i = 0; i < PlantsAlive.Length-1; i++)
        {
            int maxDays = 0;
            while(indexes.Count>0 && PlantsAlive[indexes.Peek()]>= PlantsAlive[i])
            {
                maxDays = Math.Max(maxDays, days[indexes.Pop()]);
            }
            if (indexes.Count > 0)
            {
                days[i] = maxDays + 1;
            }
            indexes.Push(i);
        }
        Console.WriteLine(days.Max());
    }
}

