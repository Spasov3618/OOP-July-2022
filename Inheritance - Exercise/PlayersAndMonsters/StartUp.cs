using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main()
        {
            Hero hero = new Hero("spasov", 10 );

            Elf elf = new Elf("gogo", 1);

            Console.WriteLine(elf);
            Console.WriteLine(hero);
        }
    }
}