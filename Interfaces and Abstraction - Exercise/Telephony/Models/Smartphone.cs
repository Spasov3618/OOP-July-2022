using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing

    {


        public string Brows(string url)
        {
            if (url.Any(n => char.IsDigit(n)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }




        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(n => char.IsDigit(n)))
            {
                throw new ArgumentException("Invalid number!");
            }
            return phoneNumber.Length > 7 ? $"Calling... {phoneNumber}" : $"Dialing... {phoneNumber}";
        }
    }

}

