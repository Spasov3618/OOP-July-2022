using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayCelebrations
{
    public class Engin 

    {
        public Engin()
        {
            list = new List<IBirthday>();
        }
      
       private List<IBirthday> list;

       public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arrg = input.Split();
                Aded(arrg);
            }
            string num = Console.ReadLine();

            List<string> arr = new List<string>();

            foreach (var item in list.Where(n=> n.Birthday.EndsWith(num)).Select(n=> n.Birthday))
            {
                arr.Add(item);

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

        private void Aded(string[] arrg)
        {
            IAdded identi;
            IBirthday identifire;
            string species = arrg[0];
            if (species == "Citizen")
            {
                string name = arrg[1];
                int age = int.Parse(arrg[2]);
                string id = arrg[3];
                string birthday = arrg[4];
                identifire = new Citizens(name, age, id,birthday);
                list.Add(identifire);

            }
            else if (species == "Pet")
            {
                string name = arrg[1];
                string birthday = arrg[2];
                identifire = new Pet(name, birthday);
            list.Add(identifire);
            }
            else
            {
                string model = arrg[1];
                string id = arrg[2];
                identi = new Robots(model, id);
            }

        }
    }
}

