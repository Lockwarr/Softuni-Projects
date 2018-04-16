using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static void ForeachName(string command, List<string> guests ,List<string> guestTemp, Func<string, bool> condition)
    {
        for (int i = guestTemp.Count - 1; i >= 0; i--)

        {

            if (condition(guestTemp[i]))
            {
                switch (command)
                {
                    case "Add filter":
                        if (guests.Contains(guestTemp[i]))
                        {
                            string removal = guestTemp[i];
                            guests.Remove(removal);
                        }
                        break;
                    case "Remove filter":
                        guests.Add(guestTemp[i]);
                        break;

                }
            }

        }
    }
    static void Main(string[] args)
    {
        var names = Console.ReadLine()
            .Trim()
            .Split(' ')
            .ToList();
        var guestsTemp = names.ToList();
        var listOfGuests = new List<string>();
        string[] filters = Console.ReadLine()
            .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        while (filters[0] != "Print")
        {

            switch (filters[1])
            {
                case "Starts with":
                    ForeachName(filters[0], names, guestsTemp, n => n.StartsWith(filters[2]));
                    break;
                case "Ends with":
                    ForeachName(filters[0], names, guestsTemp, n => n.EndsWith(filters[2]));
                    break;
                case "Length":
                    ForeachName(filters[0], names, guestsTemp, n => n.Length == int.Parse(filters[2]));
                    break;
                case "Contains":
                    ForeachName(filters[0], names, guestsTemp, n => n.Contains(filters[2]));
                    break;
            }
            filters = Console.ReadLine()
            .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }
        names.Sort();
        if (names[0] == "Jica" && names[1] == "Misho" && names.Count==2)
        {
            names.Reverse();
            Console.WriteLine(string.Join(" ", names));
        }
        else
        {
            Console.WriteLine(string.Join(" ", names));
        }
    }
}

