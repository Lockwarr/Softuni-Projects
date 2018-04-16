using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        long FibonacciSCount = long.Parse(Console.ReadLine());
        long firstF = 0;
        long secondF = 1;
       for(int i = 1; i < FibonacciSCount; i++)
        {
            long temp = firstF;
            firstF = secondF;
            secondF = temp + secondF;
        }
        Console.WriteLine(secondF);   
    }
}
