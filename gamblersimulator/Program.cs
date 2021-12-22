using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamblersimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to gambling simulator");
            Gambler gambler = new Gambler();
            gambler.Game();
            Console.ReadLine();
        }
    }
}
