using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string[,] board = new string[8, 8];
        var list = new List<int>();
        for (int i = 0; i < 8; i++)
        {
            string[] row = Console.ReadLine().Trim().Split(',').ToArray();
            for (int z = 0; z < 8; z++)
            {
                board[i, z] = row[z];
            }
        }
        string command = Console.ReadLine();
        while (command != "END")
        {
            string figureOnSquare = string.Empty;
            string squareToBeMovedOn = string.Empty;
            var matches = Regex.Matches(command, @"\d");
            foreach (Match mat4 in matches)
            {
                list.Add(int.Parse(mat4.Value));

            }
            if (command[0].ToString() != board[list[0],list[1]])
            {
                Console.WriteLine("There is no such a piece!");
            }
            else
            {
                if (list[2]>=8 || list[3] >=8 || list[2]<0 || list[3]<0)
                {
                    Console.WriteLine("Move go out of board!");
                    list.Clear();
                }
                else
                {

                    figureOnSquare = board[list[0], list[1]];
                    squareToBeMovedOn = board[list[2], list[3]];
                }


                if (command[0].ToString() != "x")
                {
                    switch (command[0])
                    {
                        case 'K':
                            if (squareToBeMovedOn != "x")
                            {
                                break;
                            }else if (list[2] - list[0] < -1 || list[2] - list[0] > 1 || list[3] - list[1] < -1 || list[3] - list[1] > 1 )
                            {
                                Console.WriteLine("Invalid move!");
                                break;
                            }
                            else
                            {
                                board[list[2], list[3]] = figureOnSquare;
                                board[list[0], list[1]] = "x";
                                break;
                            }

                        case 'R':
                            if(squareToBeMovedOn != "x")
                            {
                                break;
                            }else if(list[0]!=list[2] && list[1] != list[3])
                            {
                                Console.WriteLine("Invalid move!");
                                break;
                            }
                            else
                            {
                                board[list[2], list[3]] = figureOnSquare;
                                board[list[0], list[1]] = "x";
                                break;
                            }                            
                        case 'B':
                            if (squareToBeMovedOn != "x")
                            {
                                break;
                            } else if (!(Math.Abs(list[0]- list[2])== Math.Abs(list[1]- list[3])))
                            {
                                Console.WriteLine("Invalid move!");
                                break;
                            }
                            else
                            {
                                board[list[2], list[3]] = figureOnSquare;
                                board[list[0], list[1]] = "x";
                            }
                            break;
                        case 'Q':
                            if(squareToBeMovedOn != "x")
                            {
                                break;
                            }
                            else if ((Math.Abs(list[0] - list[2]) == Math.Abs(list[1] - list[3]) || list[0] == list[2] || list[1] == list[3]))
                            {
                                board[list[2], list[3]] = figureOnSquare;
                                board[list[0], list[1]] = "x";
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Invalid move!");
                                break;
                            }
                            
                        case 'P':
                            if(squareToBeMovedOn != "x")
                            {
                                break;
                            }else if (list[0] - list[2] != 1)
                            {
                                Console.WriteLine("Invalid move!");
                                break;
                            }
                            else
                            {
                                board[list[2], list[3]] = figureOnSquare;
                                board[list[0], list[1]] = "x";
                            }
                            break;
                    }



                }
            }
         
            
            command = Console.ReadLine();
            list.Clear();

        }

    }
}

