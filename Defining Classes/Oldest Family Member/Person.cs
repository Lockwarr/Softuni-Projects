using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    private string name;
    private int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Name
    {
        get { return name; }
        set { this.name = value; }
    }
    public int Age
    {
        get { return age; }
        set { this.age = value; }
    }

}


