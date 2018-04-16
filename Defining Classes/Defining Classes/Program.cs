using System;


class Program
{
    static void Main(string[] args)
    {
        var personObj = new Person();
        personObj.Name = "Pesho";
        personObj.Age = 20;
        var personOj2 = new Person()
        {
            Name = "Gosho",
            Age = 18
        };
        var personOj3 = new Person()
        {
            Name = "Stamat",
            Age = 43
        };


    }
}

