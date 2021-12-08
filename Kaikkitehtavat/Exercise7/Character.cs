using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Character : MovableObject, IAction
    {
        public string Name { get; set; } = "Character";

        // Default constructor

        public Character() { }

        // Overloaded constructor

        public Character(string newName)
        {
            Name = newName;
        }

        // Overloaded constructor

        public Character(string newName, int newX, int newY)
        {
            Name = newName;
            SetLocation(newX, newY);
        }

        public override void SetLocation(int newX, int newY)
        {
            x = newX;
            y = newY;
            Console.WriteLine($"Character moved to location : {GetLocation()}");
        }
        public void GetInformation()
        {
            Console.WriteLine(Name + " location " + GetLocation());
        }

        public void Action(Button button)
        {
            if (button.GetLocation() != GetLocation())
            {
                Console.WriteLine("Can't reach button");
                return;
            }
            button.PressButton();
        }
    }
}
