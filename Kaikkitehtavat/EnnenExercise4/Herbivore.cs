using System;
using System.Collections.Generic;
using System.Text;

namespace EnnenExercise4
{
    class Herbivore : Animal
    {
        public void EatPlants()
        {
            Console.WriteLine(this.GetType().Name + " is eating plants");
        }
    }
}
