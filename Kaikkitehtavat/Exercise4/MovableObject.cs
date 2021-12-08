using System;
using System.Collections.Generic;
using System.Text;
// a) Toteuta MovableObject luokka.
// Luokalla on protected int x = 0 ja int y = 0 muuttujat.
// Luokalla on myös pari funktiota:
// public void SetLocation(int newX, int newY) = jossa voidaan asettaa uudet arvot X:lle ja Y:lle
// public string GetLocation() = joka palauttaa X:n ja Y:n stringinä (tulostusta varten)
namespace Exercise45
{
    class MovableObject
    {
        protected int x = 0, y = 0;

        public void SetLocation(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
        public string GetLocation()
        {
            string location = (" X:" + x.ToString() + " Y:" + y.ToString());
            return location;
        }
    }
}
