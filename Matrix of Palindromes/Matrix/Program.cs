using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] MatrixDetails = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string[,] palindroms = new string[MatrixDetails[0],MatrixDetails[1]];

        for (int i = 0; i < MatrixDetails[0]; i++)
        {
            for (int z = 0; z < MatrixDetails[1]; z++)
            {
                int middle = i+z;
                palindroms[i, z] = $"{alphabet[i]}{alphabet[middle]}{alphabet[i]}";
            }
        }


        for(int i = 0; i < MatrixDetails[0]; i++)
        {
            for(int z = 0; z < MatrixDetails[1]; z++)
            {
                Console.Write(palindroms[i, z]+ " ");
            }
            Console.WriteLine();
        }
    }
}

