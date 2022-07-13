using System;

namespace Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
           


           
            try
            {


                CalculateSgrt( n);
                

               
            }
            catch (FormatException fe)
            {

                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        private static void CalculateSgrt(double n)
        {
            if (n>=0)
            {
                Console.WriteLine(Math.Sqrt(n));

            }
            else
            {
               throw new FormatException("Invalid number.");
            }
        }
    }
}
