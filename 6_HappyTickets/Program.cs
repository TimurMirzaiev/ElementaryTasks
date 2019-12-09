using _6_HappyTickets.HappyTicketsCore;
using System;

namespace _6_HappyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            LuckyTicketsApp app = new LuckyTicketsApp();
            app.Run(args);

            Console.ReadKey();
        }
    }
}
