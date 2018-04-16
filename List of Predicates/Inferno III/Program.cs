using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] gems = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var marked = new List<int>();        
        string[] command = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


        while (command[0] != "Forge")
        {

            if (command[0] == "Exclude")
            {
                switch (command[1])
                {
                    case "Sum Right":

                        for (int i = 0; i < gems.Count(); i++)
                        {
                            if (i + 1 > gems.Count()-1)
                            {
                                if (gems[i] +0 == int.Parse(command[2])) { marked.Add(gems[i]); }
                            }
                            else
                            {
                                if (gems[i] + gems[i + 1] == int.Parse(command[2])) { marked.Add(gems[i]); }
                            }
                        }
                        break;
                    case "Sum Left":
                        for (int i = 0; i < gems.Count(); i++)
                        {
                            if (i - 1 < 0)
                            {
                                if (gems[i] + 0 == int.Parse(command[2])) { marked.Add(gems[i]); }
                            }
                            else
                            {
                                if (gems[i] + gems[i - 1] == int.Parse(command[2])) { marked.Add(gems[i]); }
                            }
                            
                        }
                        break;
                    case "Sum Left Right":
                        for (int i = 0; i < gems.Count(); i++)
                        {
                            if (i + 1 > gems.Count()-1)
                            {
                                if (gems[i - 1] + gems[i] + 0 == int.Parse(command[2])) { marked.Add(gems[i]); }
                            }else if (i - 1 < 0)
                            {
                                if (0 + gems[i] + gems[i + 1] == int.Parse(command[2])) { marked.Add(gems[i]); }
                            }else if(i - 1 < 0 && i + 1 > gems.Count()-1)
                            {
                                if (0 + gems[i] + 0 == int.Parse(command[2])) { marked.Add(gems[i]); }
                            }
                            else
                            {
                                if (gems[i - 1] + gems[i] + gems[i + 1] == int.Parse(command[2])) { marked.Add(gems[i]); }

                            }
                        }
                        break;

                }

            }else if (command[0] == "Reverse")
            {
                if (marked.Any())
                {
                  marked.Remove(marked.Last());
                }
            }
            
         command = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
       
        for(int i = 0; i < gems.Count(); i++)
        {
            foreach(var excl in marked)
            {
                gems = gems.Where(n => n != excl).ToArray();
                
            }
        }
        Console.WriteLine(string.Join(" ", gems));

    }
}
