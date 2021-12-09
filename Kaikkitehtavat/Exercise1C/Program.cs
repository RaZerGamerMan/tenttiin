using System;
using static System.Console;
// Toteuta pääohjelmaan 2 eri Player luokan oliota. Anna kummallekin oliolle käyttäjän syötteellä eri ID.
// Vaihda olioiden ID:t keskenään, ja tulosta ne tarkistukseksi.
namespace Exercise1C
{
    class Program
    {
        class Player
        {
            public int id;


            public void PrintID()
            {
                Console.WriteLine(id);
            }
        }
        static void Main(string[] args)
        {
            Player player_0 = new Player();
            Player player_1 = new Player();
            Console.WriteLine("Give Player_0 ID:  ");
            player_0.id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give Player_1 ID:  ");
            player_1.id = Int32.Parse(Console.ReadLine());

            Console.Write("Player_0 ID: ");
            player_0.PrintID();
            Console.Write("Player_1 ID: ");
            player_1.PrintID();

            int temp = player_0.id;
            player_0.id = player_1.id;
            player_1.id = temp;

            Console.WriteLine("\nSwapped ID's");
            Console.Write("Player_0 ID: ");
            player_0.PrintID();
            Console.Write("Player_1 ID: ");
            player_1.PrintID();
        }
    }
}