using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Trim().Split(new char[] { ' ','\n','\r','\t' },StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] command = Console.ReadLine().Split(' ').ToArray();
        var list = new List<string>();

        while (command[0] != "Party!")
        {
            switch (command[0])
            {
                case "Remove":
                    switch (command[1])
                    {
                        case "EndsWith":
                            names = names.Where(n => !(n.Contains(command[2]))).ToArray();
                            break;
                        case "StartsWith":
                            names = names.Where(n => !(n.Contains(command[2]))).ToArray();
                            break;
                        case "Length":
                            names = names.Where(n => n.Length != int.Parse(command[2])).ToArray();
                            break;
                    }
                    break;
            }
            var listWithNames = names.ToList();
            switch (command[0])
            {
                case "Double":
                    switch (command[1])
                    {
                        case "EndsWith":
                            for (int i = 0; i < names.Count(); i++)
                            {
                                if (names[i].Contains(command[2]))
                                {
                                    listWithNames.Add(names[i]);
                                }
                            }
                            break;
                        case "StartsWith":
                            for (int i = 0; i < names.Count(); i++)
                            {
                                if (names[i].Contains(command[2]))
                                {
                                    listWithNames.Add(names[i]);
                                }
                            }
                            break;
                        case "Length":
                            for (int i = 0; i < names.Count(); i++)
                            {
                                if (names[i].Length == int.Parse(command[2]))
                                {
                                    listWithNames.Add(names[i]);
                                }
                            }
                            break;
                    }
                    break;
                    
            }
            listWithNames.Sort();
            names = listWithNames.ToArray();
        command = Console.ReadLine().Split(' ').ToArray();
        }
        if (names.Length == 0)
        {
            Console.WriteLine("Nobody is going to the party!");
        }
        else
        {
            Console.WriteLine(string.Join(", ", names) + " are going to the party!");
        }
    }
}

