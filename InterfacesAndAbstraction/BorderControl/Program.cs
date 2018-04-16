using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDetailsFormat> all = new List<IDetailsFormat>();
            string[] input = Console.ReadLine().Split(' ');
            while ((input[0] != "End"))
            {
                if (input.Length == 3)
                {
                    all.Add(new Citizens(input[0],input[1], input[2]));
                }else if(input.Length == 2)
                {
                    all.Add(new Robots(input[0], input[1]));
                }
                input = Console.ReadLine().Split(' '); 
            }
            
            var LastDigits = Console.ReadLine();
            all.Where(c => c.ID.ToString()
            .EndsWith(LastDigits))
            .Select( c => c.ID)
            .ToList()
            .ForEach(Console.WriteLine);
        }
    }
}
