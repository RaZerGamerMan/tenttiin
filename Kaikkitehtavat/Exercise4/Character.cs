using System;
using System.Collections.Generic;
using System.Text;
// 4 b) Toteuta Character luokka, joka perii MovableObject luokan.
// Luokalla on vain muuttuja string Name. Toteuta myös muuttujalle Get/Set metodit.
// Luokalla on myös yksi funktio: public void PrintInformation() = joka kirjoittaa konsoliin luokan nimen ja lokaation, käytä täälä GetLocation() funktiota
// Luo muutama Character olio, ja anna niille erilaisia arvoja X:lle ja Y:lle.

// 5a) Toteuta edellisen tehtävän Character luokalle useampi konstruktori.
// 1.Konstruktori, joka ei ota mitään parametrejä, 2.Konstruktori, joka ottaa string parametrin, jossa voi asettaa käyttäjälle nimen., 
// 3.Konstruktori, joka ottaa parametreina (string, int x, int y) muuttujat. Konstuktorissa annetaan Name muuttujalle annettu string parametri,
// ja int x,y annetaan konstruktorissa käytettävään SetLocation(x,y).
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
