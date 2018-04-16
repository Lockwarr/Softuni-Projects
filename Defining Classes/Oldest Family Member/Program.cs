using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Family family = new Family();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            string[] details = Console.ReadLine()
                .Split(' ')
                .ToArray();
            family
                .AddMember(new Person(details[0]
                ,int.Parse(details[1])));
        }
        Console.Write(family.GetOldestMember().Name);
        Console.Write(" ");
        Console.WriteLine(family.GetOldestMember().Age);

    }
}
