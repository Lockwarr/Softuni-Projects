using System;


class Program
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
       
            Box box = new Box();
            box.GetSA(length, width, height);
            box.GetLSA(length, width, height);
            box.GetVolume(length, width, height);
            Console.WriteLine(box.ToString());
       
    }

}
