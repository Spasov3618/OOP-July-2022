using System;
using System.Collections.Generic;

namespace Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] account = Console.ReadLine().Split(",");
            Dictionary<int,double> acc = new Dictionary<int,double>();
            for (int i = 0; i < account.Length; i++)
            {
                string[] arr = account[i].Split("-");
                int bankNumber = int.Parse(arr[0]);
                double sum = double.Parse(arr[1]);
                acc.Add(bankNumber,sum);

            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                try
                {
                    if (command[0] == "Deposit")
                    {
                        int bankNumber = int.Parse(command[1]);
                        double sum = double.Parse(command[2]);
                        acc[bankNumber] += sum;
                        Console.WriteLine($"Account {bankNumber} has new balance: {acc[bankNumber]}");
                    }
                    else if (command[0] == "Withdraw")
                    {
                        int bankNumber = int.Parse(command[1]);
                        double sum = double.Parse(command[2]);
                        if (acc[bankNumber]>= sum)
                        {
                        acc[bankNumber] -= sum;
                            Console.WriteLine($"Account {bankNumber} has new balance: {acc[bankNumber]}");

                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid account!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
