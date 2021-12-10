using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace SmallRPG
{
    class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public string TextArt { get; protected set; }
        public ConsoleColor Color { get; protected set; }
        public Random RandGenerator { get; protected set; }
        public bool IsDead { get => Health <= 0; }
        public bool IsAlive { get => Health > 0; }

        public Character(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Color = color;
            TextArt = textArt;
            RandGenerator = new Random();
        }

        public void DisplayInfo()
        {
            BackgroundColor = Color;
            WriteLine($"---{Name}---");
            ResetColor();

            ForegroundColor = Color;
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Elämäpisteet: {Health}");
            WriteLine("---");
            ResetColor();
        }
        public virtual void Fight(Character otherCharacter)
        {

            WriteLine("tapellaaaaan!");
        }

        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void DisplayHealthBar()
        {
            ForegroundColor = Color;
            WriteLine($"{Name} elämäpisteet:");
            ResetColor();
            Write("[");
            // näytä täytetyt elämäpalkit/pisteet
            BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < Health; i++)
            {
                Write(" ");
            }
            // näytä täyttämättömät elämäpalkit/pisteet
            BackgroundColor = ConsoleColor.Black;
            for (int i = Health; i < MaxHealth; i++)
            {
                Write(" ");
            }
            ResetColor();
            WriteLine($"] ({Health}/{MaxHealth})");
        }

    }
}
