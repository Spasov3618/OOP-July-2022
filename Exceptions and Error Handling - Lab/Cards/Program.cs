using System;
using System.Collections.Generic;
using System.Text.Encodings;

namespace Cards

{
    public  class Card
    {
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
           // Cards = new List<Card>();
        }

        public string Face { get; set; }
        public string Suit { get; set; }
       // public List<Card> Cards { get; set; }

        public override string ToString()
        {
            return $"[{Face}{Suit}] ";
        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> teste = new List<Card>();
            
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                AddCard(input, teste);
               
               

            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
            foreach (var item in teste)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        private static List<Card> AddCard(string[] input, List<Card> teste)
        {
            
            for (int i = 0; i < input.Length; i++)
            {
                int num;
               string card = input[i];
                string[] arr = card.Split();
                string face = arr[0];
                string suit = arr[1];
                if (int.TryParse(face,out num)) 
                {
                    if (num >1 && num <11)
                    {
                        face = num.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Invalid card!");
                        continue;
                    }
                }
                else
                {
                    if (face != "J" && face != "Q" && face != "K" && face != "A")
                    {
                        Console.WriteLine("Invalid card!");
                        continue;
                    }
                }
                switch (suit)
                {
                    case "S":
                        suit = "\u2660";
                        break;
                        case "H":
                        suit = "\u2665";
                        break;
                    case "D":
                        suit = "\u2666";
                        break;
                    case "C":
                        suit = "\u2663";
                        break;
                    default:
                        Console.WriteLine("Invalid card!");
                        continue;
                        
                       
                }
                Card cards = new Card(face, suit);

                teste.Add(cards);

            }
            return teste;
        }
    }
}
