using System;

namespace kaikki
{
    class Program
    {
        class Player
        {
            public uint id;


            public void PrintID()
            {
                Console.WriteLine("Player id: " + id);
            }
        }
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PrintID();

        }
    }
}
