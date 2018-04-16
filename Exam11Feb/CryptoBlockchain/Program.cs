using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        string cols = Console.ReadLine();
        string chain = string.Empty;
        string SENTENCE = string.Empty;
        int lenght = 0;
        var numbersToDecrypt = new List<int>();
        var list = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        var code = new List<string>();
        var cryptolenghts = new List<int>();
        int counter = 0;
        int finalCounter = 0;
        var howmanyNuminCrypt = new List<int>();
        for(int i = rows-1; i>0; i--)
        {
         
            chain += cols;
            cols = Console.ReadLine();
            
        }
        chain += cols;
        Regex regex = new Regex(@"({\[^][]+?\})|(\[[^}{]+?\])");
        MatchCollection matches = regex.Matches(chain);
        foreach (Match mat4 in matches)
        {
            howmanyNuminCrypt.Add(0);
            for (int i = 0; i < mat4.Length; i++)
            {
                string anymatch = mat4.Value;
                if (list.Contains(anymatch[i].ToString()))
                {
                    code.Add(anymatch[i].ToString());
                    howmanyNuminCrypt[counter]++;
                }
                lenght = mat4.Length;
            }
            counter++;
            cryptolenghts.Add(lenght);
            if (code.Count() % 3 != 0 || code.Count() < 3)
            {
                code.Clear();
            }
        }
       
       
        int numbersCounter = 0;
        for (int i = 0; i < code.Count(); i+=3)
        {
            int number = int.Parse(code[i] + code[i + 1] + code[i + 2]);
            if (howmanyNuminCrypt[finalCounter]/3 == numbersCounter)
            {
                finalCounter++;
                numbersCounter = 0;
            }
            numbersCounter++;
            numbersToDecrypt.Add(number-cryptolenghts[finalCounter]);
        }
        for (int i = 0; i < numbersToDecrypt.Count(); i++)
        {
            char word = Convert.ToChar(numbersToDecrypt[i]);
            SENTENCE += word.ToString();
        }
        Console.WriteLine(SENTENCE);
    }
}

