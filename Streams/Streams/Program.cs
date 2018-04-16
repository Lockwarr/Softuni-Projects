using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("text.txt");
        using (reader)
        {
            int lineNum = 0;
            string line = reader.ReadLine();
            while (line !=null)
            {
                if (lineNum % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                    lineNum++;
                line = reader.ReadLine();
            }
        }
    }
}
