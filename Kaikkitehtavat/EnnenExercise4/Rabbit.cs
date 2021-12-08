using System;
using System.Collections.Generic;
using System.Text;

namespace EnnenExercise4
{
    class Rabbit : Herbivore
    {
        private float speed;

        public Rabbit(float newSpeed)
        {
            speed = newSpeed;
        }
        public void Jump(int times)
        {
            //todo: jumping mechanics
            Console.WriteLine("Rabbit would jump" + times);
        }
    }
}