using System;
using static System.Console;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Character C1 = new Character("Jack", 3, 5);

            Button button = new Button();
            button.SetLocation(3, 3);

            C1.Action(button);
            C1.SetLocation(3, 3);
            C1.Action(button);
            C1.Action(button);
        }
    }
}
