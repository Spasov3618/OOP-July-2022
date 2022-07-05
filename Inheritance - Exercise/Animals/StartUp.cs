namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
       public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "Beast!")
                {
                    break;
                }

                string animalType = inputLine.Trim();
                string[] animalInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    Animal animal = Animal.Create( animalInfo[0]
                                         , int.Parse(animalInfo[1]), animalInfo[2], animalType);

                    animals.Add(animal);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}