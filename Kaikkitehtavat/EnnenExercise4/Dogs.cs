using System;
using System.Collections.Generic;
using System.Text;

namespace EnnenExercise4
{
    class Dog : Animal
    {
        public int age = 0;
        public Dog(int newAge)
        {
            age = newAge;
        }
        public void Bark()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
