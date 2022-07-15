using System;
using System.Linq;

namespace Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            while (counter<3)
            {
                string[] command = Console.ReadLine().Split();
                try
                {
                    string arr = command[0];
                    if (arr == "Replace")
                    {
                        int index = int.Parse(command[1]);
                        int num = int.Parse(command[2]);
                        input[index] = num;
                    }
                    else if (arr == "Show")
                    {
                        int index = int.Parse(command[1]);
                        Console.WriteLine(input[index]);
                    }
                    else if (arr == "Print")
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        int[] printArr = new int[endIndex - startIndex+1];
                        int intex = 0;
                        for (int i = startIndex; i <= endIndex ; i++)
                        {
                             printArr[intex] = input[i];
                            intex++;

                        }
                        Console.WriteLine($"{string.Join(", ",printArr).ToString()}");
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    counter++;
                }
                catch(FormatException) 
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    counter++;
                }
            }
            Console.WriteLine($"{string.Join(", ", input).ToString()}");
        }
    }
}
