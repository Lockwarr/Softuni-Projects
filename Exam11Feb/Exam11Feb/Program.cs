using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        int gunBarrelSize = int.Parse(Console.ReadLine());
        int[] bullets1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
        var bullets = new Stack<int>();
        foreach (var bull in bullets1)
        {
            bullets.Push(bull);
        }
        int[] locks1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
        var locks = new Queue<int>();
        foreach (var lok in locks1)
        {
            locks.Enqueue(lok);
        }
        int intelligence = int.Parse(Console.ReadLine());
        while (true)
        {
            for (int i = 0; i < gunBarrelSize; i++)
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    locks.Dequeue();
                    bullets.Pop();
                    Console.WriteLine("Bang!");
                    intelligence -= bulletPrice;
                }
                else if (bullets.Peek() > locks.Peek())
                {
                    bullets.Pop();
                    Console.WriteLine("Ping!");
                    intelligence -= bulletPrice; 
                }
            }
            if (locks.Count() == 0)
            {
                if (bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
                Console.WriteLine("{0} bullets left. Earned ${1}", bullets.Count(), intelligence);
                break;
            }
            else
            {
                if (bullets.Count > 0)
                {
                    if (gunBarrelSize > bullets.Count())
                    {
                        gunBarrelSize = bullets.Count();
                    }
                    Console.WriteLine("Reloading!");
                }
                else
                {

                    Console.WriteLine("Couldn't get through. Locks left: {0}", locks.Count());
                    break;
                }
            }
        }
    }
}

