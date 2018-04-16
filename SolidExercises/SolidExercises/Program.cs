using SolidExercises;
using SolidExercises.Contracts;
using SolidExercises.Layouts;
using System;


public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Engine engine = new Engine();
        for (int i = 0; i < n; i++)
        {
            engine.RegisterAppender(Console.ReadLine());
        }
        engine.InitializeLogger();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            engine.RecordMessage(input);
        }
        Console.WriteLine("Logger info");
        engine.PrintLoggerInfo();

    }
}
