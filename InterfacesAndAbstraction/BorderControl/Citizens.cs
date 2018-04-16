using System;
using System.Collections.Generic;
using System.Text;


class Citizens : IDetailsFormat
{
    public string Name { get; private set; }
    public string ID { get; private set; }
    private string age;
    public Citizens(string name, string age , string id)
    {
        this.Name = name;
        this.age = age;
        this.ID = id;
    }
  

}
