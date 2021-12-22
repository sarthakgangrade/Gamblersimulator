using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamblersimulator
{
    class Gambler
    {
        public void Game()
        {
            int stack = 100;
            int bet = 1;
            Console.WriteLine("Every Day Stack is " + stack);
            Console.WriteLine("EveryTime Bet is " + bet);
            Random random = new Random();
            int game = random.Next(0, 2);
            if (game == 1)
            {
                Console.WriteLine("Gambler Won the Game ");
                stack += 1;
            }
            else
            {
                Console.WriteLine("Gambler Lost the Game ");
                stack -= 1;
            }
            Console.WriteLine("Final Stack: " + stack);
        }
    }
}
