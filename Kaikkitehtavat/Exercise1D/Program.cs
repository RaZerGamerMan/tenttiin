using System;
using static System.Console;
// Toteuta ohjelmaan toinen luokka Bike.
// Anna luokalle uusi muuttuja (uint) vuosimalli public uint ym;
// Luo pääohjelmassa Bike -luokasta uusi olio. Anna olion vuosimalli muuttujalle sekalainen numero väliltä 1960 - 2021.
// Random luokka juttu
// Testaa ohjelman toiminta tulostamalla Bike olion vuosimalli konsoliin.

// EXTRA: Toteuta useampi Bike olio, ja arvo niille samanlailla vuosimalli eri väliltä. Hyödynnä tässä taulukointia ja looppia!

namespace Exercise1D
{
    class Program
    {
        // <summary> Bike class ym = year model. Not initialized.
        class Bike
        {
            public uint ym;
        }
        static void Main(string[] args)
        {
            // Instantiate a new Bike object, and give it a year model.
            // Print it

            Bike bike0 = new Bike();
            bike0.ym = 1967;
            Console.WriteLine("Bike year model " + bike0.ym.ToString());

            // Let's make a second bike, and give it random year model between 1960-2021
            // For this exercise, we need to use random class

            Random rand = new Random();
            Bike bike1 = new Bike();

            // We need to cast int to uint

            bike1.ym = (uint)rand.Next(1960, 2021);
            Console.WriteLine("Second bike year model: " + bike1.ym.ToString());

            // Extra exercise
            Bike[] bikes = new Bike[10];
            for (int i = 0; i < bikes.Length; i++)
            {
                bikes[i] = new Bike();
                bikes[i].ym = (uint)rand.Next(1960, 2021);
                Console.WriteLine("{0}[{1}] year model: {2}", bikes[i].GetType().Name, i, bikes[i].ym.ToString());
            }
        }
    }
}
