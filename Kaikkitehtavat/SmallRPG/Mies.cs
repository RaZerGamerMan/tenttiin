using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Mies : Character
    {
        public Mies(string name, int health, ConsoleColor color, int chargeAttack)
            : base(name, health, color, Arts.Mies)
        {
            
        }

        public override void Fight(Character otherCharacter)
        {
            // -50% ajasta lyönti osuu
            // -50% ajasta lyönti menee ohi

            ForegroundColor = Color;
            ResetColor();
            int randPercent = RandGenerator.Next(1, 101);
            Write($"Juoppo {Name} hyökkää sinuun ja ");
            if (randPercent <= 50)
            {
                WriteLine("osuu 4 osumaa!");
                otherCharacter.TakeDamage(4);
            }
            else
            {
                WriteLine("ohi menee...");
            }
            ResetColor();
        }
    }
}
