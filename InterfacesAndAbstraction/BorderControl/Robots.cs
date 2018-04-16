using System;
using System.Collections.Generic;
using System.Text;


class Robots : IDetailsFormat
{
    public string Name { get; private set; }
    public Robots(string name , string id)
    {
        this.Name = name;
        this.ID = id;

    }
    public string ID { get; private set; }
}
