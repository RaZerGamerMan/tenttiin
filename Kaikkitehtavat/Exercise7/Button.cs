using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Button : MovableObject
    {
        public bool IsPressed { get; private set; } = false;
        public override void SetLocation(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
        public void PressButton()
        {
            if (IsPressed)
            {
                Console.WriteLine("This button has already been pressed.");
                return;
            }
            IsPressed = true;
            Console.WriteLine($"Button pressed.");
        }
    }
}
