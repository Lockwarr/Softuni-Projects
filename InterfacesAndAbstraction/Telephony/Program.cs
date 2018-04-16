using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] links = Console.ReadLine().Split(' ');
            var smFone = new Smartphone();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(smFone.Call(numbers[i]));
            }
            foreach (var url in links)
            {
                Console.WriteLine(smFone.Browse(url));
            }
        }
    }
}