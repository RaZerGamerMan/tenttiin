using System;
using System.Collections.Generic;
using System.Text;
// b) Toteuta Character luokka, joka perii MovableObject luokan.
// Luokalla on vain muuttuja string Name. Toteuta myös muuttujalle Get/Set metodit.
// Luokalla on myös yksi funktio: public void PrintInformation() = joka kirjoittaa konsoliin luokan nimen ja lokaation, käytä täälä GetLocation() funktiota
// Luo muutama Character olio, ja anna niille erilaisia arvoja X:lle ja Y:lle.

namespace Exercise45
{
    class Character : MovableObject
    {

        public string name { get; set; } = "Default";

        // Default constructor
        public Character() { }

        // Second constructor
        public Character(string cName)
        {
            name = cName;
        }

        // Third Constructor
        public Character(string cName, int x, int y)
        {
            name = cName;
            SetLocation(x, y);
        }

        // GetInformation method prints character name and location
        // We can call GetLocation() method from the parent class, because of the inheritance
        public void PrintInformation()
        {
            Console.WriteLine(name + " location " + GetLocation());
        }
    }
}
