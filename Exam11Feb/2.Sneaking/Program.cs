using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        string col = Console.ReadLine();

        var room = new List<List<string>>();
        for (int i = 0; i < rows; i++)
        {
            for (int z = 0; z < col.Count(); z++)
            {
                room[i, z] = col[z].ToString();
            }
            if (i < rows - 1)
            {
                col = Console.ReadLine();
            }

        }
    }
}