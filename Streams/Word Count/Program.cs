using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("text.txt");
        StreamWriter printer = new StreamWriter("result.txt");
        string line = reader.ReadLine();
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        while (line != null)
        {
            var wordsInLine = line
                .Split(' ')
                .ToArray();
            foreach (var word in wordsInLine)
            {
                if (word == "quick" || word =="Quick")
                {
                    counter1++;
                } else if (word == "is" || word == "Is")
                {
                    counter2++;
                } else if (word == "fault" || word =="Fault")
                {
                    counter3++;
                }
            }
            line = reader.ReadLine();
        }
        if(counter1>counter2 && counter1 > counter3)
        {
            Console.WriteLine($"quick - {counter1}");
            if (counter2 > counter3)
            {
                Console.WriteLine($"is- {counter2}");
                Console.WriteLine($"fault- {counter3}");
            }
            else
            {
                Console.WriteLine($"fault- {counter3}");
                Console.WriteLine($"is- {counter2}");
            }
        }else if(counter2>counter1 && counter2 > counter3)
        {
            Console.WriteLine($"is - {counter2}");
            if (counter1 > counter3)
            {
                Console.WriteLine($"quick- {counter1}");
                Console.WriteLine($"fault- {counter3}");
            }
            else
            {
                Console.WriteLine($"fault- {counter3}");
                Console.WriteLine($"quick- {counter1}");
            }
        }
        else
        {
            Console.WriteLine($"fault - {counter3}");
            if (counter1 > counter2)
            {
                Console.WriteLine($"quick- {counter1}");
                Console.WriteLine($"is- {counter2}");
            }
            else
            {
                Console.WriteLine($"is- {counter2}");
                Console.WriteLine($"quick- {counter1}");
            }
        }

    }
}