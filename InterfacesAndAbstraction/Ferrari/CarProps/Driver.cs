using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari.CarProps
{
    public class Driver
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Driver(string name)
        {
            this.Name = name;

        }

    }
}
