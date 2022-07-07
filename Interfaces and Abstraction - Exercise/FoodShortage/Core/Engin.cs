using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShortage
{
    public class Engin 

    {
        public Engin()
        {
            citizens = new List<Citizens>();
            rebels= new List<Rebel>();
            TotalFood = 0;

        }
      
       private List<Citizens> citizens;
        private List<Rebel> rebels;
        public int TotalFood;

       public void Run()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Aded(input);
            }

            string buyFood;
            while ((buyFood = Console.ReadLine()) != "End")
            {
                if (citizens.Any(n=> n.Name == buyFood))
                {
                    TotalFood += 10; 
                }
                else if (rebels.Any(n=>n.Name == buyFood))
                {
                    
                    TotalFood += 5;
                }

            }
            Console.WriteLine(TotalFood);

           

        }

        private void Aded(string[] input)
        {
            
            Citizens citizen;
            Rebel rebel;

            if (input.Length == 4)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string id = input[2];
                string birthday = input[3];
                citizen = new Citizens(name, age, id,birthday);
                citizens.Add(citizen);

            }
           
            else
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string group  = input[2];
                rebel = new Rebel(name,age,group);
               rebels.Add(rebel);
            }

        }
    }
}

