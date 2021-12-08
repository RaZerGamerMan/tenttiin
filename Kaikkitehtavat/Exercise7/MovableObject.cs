using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    abstract class MovableObject
    {
        protected int x = 0, y = 0;
        public abstract void SetLocation(int newX, int newY);
        public string GetLocation()
        {
            return $"{x}, {y})";
        }
    }
}