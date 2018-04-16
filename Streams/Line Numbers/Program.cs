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
            while(line != null)
            {
                lineNum++;
                Console.WriteLine("Line{0} :{1}", lineNum, line);
                line = reader.ReadLine();
            }
        }
    }
}
