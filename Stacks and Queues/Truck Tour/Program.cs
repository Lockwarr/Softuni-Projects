using System;
using System.Collections.Generic;
using System.Linq;


   public class Program
{
    public static void Main(string[] args)
    {
        int Count = int.Parse(Console.ReadLine());
        var queue = new Queue<int[]>();
        for(int i = 0; i < Count; i++)
        {
            
            var pump= Console.ReadLine()
             .Trim()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
            queue.Enqueue(pump);
        }
        for(int i = 0; i < Count-1; i++)
        {
            int fuel = 0;
            bool isSolution = true;
            for (int z = 0; z < Count; z++)
            {
                var currentPump = queue.Dequeue();
                
                var pumpFuel = currentPump[0];
                var nextPumpDistance = currentPump[1];
                queue.Enqueue(currentPump);
                fuel += pumpFuel - nextPumpDistance;
                if (fuel < 0)
                {
                    i += z;
                    isSolution = false;
                    break;
                }
            }
            if (isSolution)
            {
                Console.WriteLine(i);
                Environment.Exit(0);
            }
        }
    }
}

