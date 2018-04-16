using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var listOfPeople = new List<Person>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            listOfPeople
                .Add(new Person(input[0]
                , int.Parse(input[1])));
        }
        listOfPeople.OrderByDescending(p => p.age > 30);
        foreach (var man in listOfPeople.OrderByDescending(p => p.age))
        {
            if (man.age > 30)
            {
                Console.Write(man.name);
                Console.Write(" - ");
                Console.WriteLine(man.age);
            }
        }
    }
}
