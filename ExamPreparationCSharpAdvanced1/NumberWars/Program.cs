using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        bool flag = false;
        string[] player11 = Console.ReadLine().Trim().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] player22 = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Queue<string> player1 = new Queue<string>();
        Queue<string> player2 = new Queue<string>();
        var list = new List<string>();
        int turns = 0;
        Dictionary<string, int> valuesAlphabet = new Dictionary<string, int>()
        {
            {"a",1 },
            {"b",2 },
            {"c",3 },
            {"d",4 },
            {"e",5 },
            {"f",6 },
            {"g",7 },
            {"h",8 },
            {"i",9 },
            {"j",10 },
            {"k",11},
            {"l",12},
            {"m",13},
            {"n",14},
            {"o",15},
            {"p",16},
            {"q",17},
            {"r",18},
            {"s",19},
            {"t",20},
            {"u",21},
            {"v",22},
            {"w",23},
            {"x",24},
            {"y",25},
            {"z",26},

        };

        Regex regex = new Regex(@"\d+");
        foreach (var card in[ player11)
        {
            player1.Enqueue(card);
        }
        foreach (var card in player22)
        {
            player2.Enqueue(card);
        } 
        int DrawChecker = 0;
        while (turns < 1000000)
        {
            if (flag)
            {
                
                break;

            }
            for (int i = 0; i < player11.Count(); i++)
            {
                if (player11[i] == player22[i])
                {
                    DrawChecker++;
                }
            }
            if (DrawChecker == player11.Count())
            {
                turns++;
                Console.Write("Draw ");
                break;
            }

            if (player1.Count() == 0)
            {
                
                Console.Write("Second player wins ");
                break;
            }else if (player2.Count() == 0)
            {
                
                Console.Write("First player wins ");
                break;
            }
           
            int result1 = int.Parse(Regex.Match(player1.Peek(), @"\d+").Value);
            int result2 = int.Parse(Regex.Match(player2.Peek(), @"\d+").Value);

            if (result1 > result2)
            {
                
                list.Add(player2.Dequeue());
                list.Add(player1.Dequeue());
                list.Sort((a, b) => -1 * a.CompareTo(b));

                foreach (var item in list)
                {
                    player1.Enqueue(item);
                }
                
               
            }
            else if (result1 < result2)
            {
                list.Add(player2.Dequeue());
                list.Add(player1.Dequeue());
                list.Sort((a, b) => -1 * a.CompareTo(b));

                foreach (var item in list)
                {
                    player2.Enqueue(item);
                }
               
               
            }
            while (result1 == result2)
            {

                string card1P1 = player1.Dequeue();
                if (player1.Count() == 0)
                {
                    flag = true;
                    Console.Write("Second player wins ");
                    break;
                }
                string card2P1 = player1.Dequeue();
                if (player1.Count() == 0)
                {
                    flag = true;
                    Console.Write("Second player wins ");
                    break;
                }
                string card3P1 = player1.Dequeue();
                if (player1.Count() == 0)
                {
                    flag = true;
                    Console.Write("Second player wins ");
                    break;
                }
                string card1P2 = player2.Dequeue();
                if (player2.Count() == 0)
                {
                    flag = true;
                    Console.Write("First player wins ");
                    break;
                }


                string card2P2 = player2.Dequeue();
                if (player2.Count() == 0)
                {
                    flag = true;
                    Console.Write("First player wins ");
                    break;
                }


                string card3P2 = player2.Dequeue();
                if (player2.Count() == 0)
                {
                    flag = true;
                    Console.Write("First player wins ");
                    break;
                }


                string letter1P1 = Regex.Match(card1P1, @"[A-z]").Value;
                string letter2P1 = Regex.Match(card2P1, @"[A-z]").Value;
                string letter3P1 = Regex.Match(card3P1, @"[A-z]").Value;
                string letter1P2 = Regex.Match(card1P2, @"[A-z]").Value;
                string letter2P2 = Regex.Match(card2P2, @"[A-z]").Value;
                string letter3P2 = Regex.Match(card3P2, @"[A-z]").Value;
                list.Add(card1P1);
                list.Add(card2P1);
                list.Add(card3P1);
                list.Add(card1P2);
                list.Add(card2P2);
                list.Add(card3P2);
                int value1 = valuesAlphabet[letter1P1];
                int value2 = valuesAlphabet[letter2P1];
                int value3 = valuesAlphabet[letter3P1];
                int value4 = valuesAlphabet[letter1P2];
                int value5 = valuesAlphabet[letter2P2];
                int value6 = valuesAlphabet[letter3P2];

                if (value1 + value2 + value3 > value4 + value5 + value6)
                {
                    list.Sort((a, b) => -1 * a.CompareTo(b));
                    foreach (var item in list)
                    {
                     
                        player1.Enqueue(item);
                        list = new List<string>();
                    }
                }
                else if (value1 + value2 + value3 < value4 + value5 + value6)
                {
                    list.Sort((a, b) => -1*a.CompareTo(b));
                    foreach (var item in list)
                    {
                        player2.Enqueue(item);
                        list = new List<string>();
                    }
                }

                
            }
            list = new List<string>();
            turns++;
        }
        if (turns == 1000000)
        {
            if (player1.Count > player2.Count)
            {
                Console.Write("First player wins ");
            }
            else if (player2.Count > player1.Count)
            {
                Console.Write("Second player wins ");
            }
            else
            {
                Console.Write("Draw ");
            }
        }
        Console.WriteLine("after {0} turns", turns);
    }
}
