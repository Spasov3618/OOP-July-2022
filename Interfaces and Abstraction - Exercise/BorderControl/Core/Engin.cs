using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Engin 

    {
        public Engin()
        {
            list = new List<IAdded>();
        }
      
       private List<IAdded> list;

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
            foreach (var item in list.Where(n=> n.Id.EndsWith(num)).Select(n=> n.Id))
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
            if (arrg.Length == 3)
            {
                string name = arrg[0];
                int age = int.Parse(arrg[1]);
                string id = arrg[2];
                identi = new Citizens(name, age, id);

            }
            else
            {
                string model = arrg[0];
                string id = arrg[1];
                identi = new Robots(model, id);
            }
            list.Add((identi));
        }
    }
}

