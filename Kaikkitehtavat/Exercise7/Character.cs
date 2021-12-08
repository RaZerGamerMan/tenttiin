using System;
using System.Collections.Generic;
using System.Text;
// b2) Lisää kyseinen rajapinta Character luokalle, ja tee sille rajapinnan funktion toteutus.
// Funktiossa on tarkoitus kutsua parametriksi annetun painikkeen PressButton(bool) funktiota.
// Huomioi Action(Button) -funktion toteutuksessa seuraavat asiat:
// PressButton() -funktiota ei voi kutsua, jos painike ei ole samassa sijainnissa hahmon kanssa. Eli hahmo ei yllä siihen. Toteuta tästä tulostus konsoliin.
// Painiketta voi painaa vaan kerran -> tulosta konsoliin, jos painiketta on jo painettu.

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
