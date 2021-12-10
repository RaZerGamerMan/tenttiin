using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SmallRPG
{
    class Mies2 : Character
    {
        public Mies2(string name, int health, ConsoleColor color, bool knifeAttack)
            : base(name, health, color, Arts.Mies2)
        {            
            RandGenerator = new Random();
        }

        public override void Fight(Character otherCharacter)
        {
            // -60% ajasta lyö 6 osumaa
            // -40% ajasta lyö ohi
            ForegroundColor = Color;
            ResetColor();
            int randPercent = RandGenerator.Next(1, 101);
            Write($"Juoppo {Name} lyö sinua ja ");
            if (randPercent <= 60)
            {
                WriteLine("osuu 6 osumaa!");
                otherCharacter.TakeDamage(6);
            }
            else
            {
                WriteLine("ohi menee...");
            }
            // -6% mahdollisuus kuolla puukkoon välittömästi
            // -94% puukko menee ohi
            Write($"Juoppo {Name} yrittää puukottaa sinua ja ");
            if ( randPercent <= 6)
            {
                WriteLine("puukko uppoaa päähäsi, kuin sulaan voihin!!!");
                otherCharacter.TakeDamage(50);
            }
            else
            {
                WriteLine("huitaisee ohitse.");
            }

            ResetColor();

        }
    }
}
