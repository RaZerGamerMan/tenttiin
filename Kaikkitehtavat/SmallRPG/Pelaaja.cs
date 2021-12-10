using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Pelaaja : Character
    {
        public Pelaaja(string name, int health, ConsoleColor color)
            : base(name, health, color, Arts.Pelaaja)
        {

        }

        private void BenchFlies (Character otherCharacter)
        {
            Write("Heität jakkaralla ");
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 90)
            {
                WriteLine("ja osuu!");
                otherCharacter.TakeDamage(3);
            }
            else
            {
                WriteLine("ja ohi menee...");
            }
        }

        private void BigHit (Character otherCharacter)
        {
            Write("Lyöt ihan olan takaa ");
            int randPercent = RandGenerator.Next(1, 101);
            if (randPercent <= 60)
            {
                WriteLine("ja osuu ihan kunnolla!");
                otherCharacter.TakeDamage(6);
            }
            else
            {
                WriteLine("ja ohi menee...");
            }
        }
        public override void Fight(Character otherCharacter)
        {
            

            ForegroundColor = Color;
            WriteLine($@"Vastassasi on {otherCharacter.Name}. Mitäpä haluaisit tehdä?

 1) Heitä jakkaralla (90% mahdollisuus tehdä 3 osumaa)
 2) Lyö ihan olan takaa (50% mahdollisuus tehdä 6 osumaa)
");
            ConsoleKeyInfo keyInfo = ReadKey(true);
            if (keyInfo.Key == ConsoleKey.D1)
            {
                BenchFlies(otherCharacter);
            }
            else if (keyInfo.Key == ConsoleKey.D2)
            {
                BigHit(otherCharacter);
            }
            else
            {
                WriteLine("Et sinä nyt tuota nappia voi painaa. Kokeile uudestaan.");
                Fight(otherCharacter);
                return;
            }
            ResetColor();
        }
    }
}