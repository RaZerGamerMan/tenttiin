using System;
// Toteuta ohjelmaan uusi luokka Player. Luo uusi olio luokasta pääohjelmassa. 
// 1. Yksi muuttuja esim. public int id;
// 2. Funktio, joka tulostaa muuttujan esim. public void PrintID();
namespace Exercise1AB
{
    class Program
    {
        class Player
        {
            public int id;


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
