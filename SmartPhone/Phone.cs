using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartPhone
{
    internal class Phone:IBrowsable,ICallable
    {
        public void Call(string phoneNumber)
        {
            string pattern = @"[^\d]";
            Match match = Regex.Match(phoneNumber, pattern);
            if (match.Success)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {phoneNumber}");
            }
        }

        public void Browse(string url) 
        {
            string pattern = @"\d";
            Match match = Regex.Match(url, pattern);
            if (match.Success)
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing... {url}");
            }
        }
    }
}
