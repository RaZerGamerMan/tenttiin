using System;
using static System.Console;

namespace SmallRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pieni RPG";

            Game myGame = new Game();
            myGame.Run();
            bool isResponseValid = false;
            do
            {
                WriteLine("Haluatko pelata uudelleen?(K/E)");
                string response = ReadLine().Trim().ToUpper();
                if (response == "K")
                {
                    Clear();
                    myGame.Run();
                }
                else
                {
                    break;
                }


            } while (!isResponseValid);
        }
    }
}
