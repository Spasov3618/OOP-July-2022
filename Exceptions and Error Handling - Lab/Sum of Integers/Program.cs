using System;

namespace Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {


                try
                {
                    sum += int.Parse(input[i]);
                    
                    
                }
                catch (FormatException )
                {

                    Console.WriteLine($"The element '{input[i]}' is in wrong format!");
                  
                }
                catch (OverflowException )
                {
                    Console.WriteLine($"The element '{input[i]}' is out of range!");
                }
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {sum}");
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
           
        }

          }
}
