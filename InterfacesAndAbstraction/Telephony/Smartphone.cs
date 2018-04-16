using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Telephony
{
    class Smartphone : Functionalities.Icall, Functionalities.IbrowseWWW
    {
        public string Call(string number)
        {
            if (!number.All(Char.IsDigit))
            {
                return "Invalid number!";
            }
            else
            {
                return $"Calling... {number}";
            }
                ;
        }
        public string Browse(string url)
        {
            if(url.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {url}!";
            }
        }
        
    }
}
