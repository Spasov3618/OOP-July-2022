﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {

                //array[i] = ReadNumber(start, end);

                try
                {
                    array[i] = ReadNumber(start, end);


                    if (array[i] <= start || array[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    i--;
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Your number is not in range {0} - {1}!", start, end);
                    i--;
                    continue;
                }


                start = array[i];
            }

           // Console.Write("Your numbers are: ");
            //foreach (var n in array)
            //{
            //    Console.Write(n + ", ");
            //}
            //Console.WriteLine();

            Console.WriteLine($"{string.Join(", ",array).ToString()}");
        }
        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                throw new FormatException();
            }


            return num;
        }

    }
}