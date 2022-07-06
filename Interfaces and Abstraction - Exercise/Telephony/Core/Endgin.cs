using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class Endgin : Smartphone, ICalling, IBrowsing
    {
        public Endgin()
        {
            smartfone = new Smartphone();
            phoneNumbers = new List<string>();
            urls = new List<string>();
        }
        private Smartphone smartfone;
        private List<string> phoneNumbers;
        private List<string> urls;

        public void Run()
        {
            phoneNumbers = Console.ReadLine().Split().ToList();
            urls = Console.ReadLine().Split().ToList();

            callPhoneNumber();
            browseeng();
        }

        private void browseeng()
        {
            foreach (var item in urls)
            {
                try
                {
                Console.WriteLine(smartfone.Brows(item));

                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
        }

        private void callPhoneNumber()
        {
            foreach (var item in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(smartfone.Call(item));
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

            }
        }
    }
}
