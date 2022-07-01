namespace _05._Pizza_Calories
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {

                string input = Console.ReadLine();
                Pizza pizza = new Pizza(input.Split()[1]);

                while (input != "END")
                {
                    string[] args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (args[0] == "Dough")
                    {
                        var dough = new Dough(args[1], args[2], decimal.Parse(args[3]));

                        pizza.Dough = dough;
                    }
                    else if (args[0] == "Topping")
                    {
                        var topping = new Topping(args[1], decimal.Parse(args[2]));

                        pizza.AddTopping(topping);
                    }

                    input = Console.ReadLine();
                }

                Console.WriteLine(pizza);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}