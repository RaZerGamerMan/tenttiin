using System;
using System.Collections.Generic;

namespace EnnenExercise4
{

    class FooMaster
    {
        protected string name = "FooMaster";
        public void PrintSomething(string something)
        {
            //Console.WriteLine(this.GetType().Name + " says " + something);
            Console.WriteLine(name + " says " + something);

        }
    }
    class Foo : FooMaster
    {
        public Foo(string newName)
        {
            name = newName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(5);
            Console.WriteLine("Dog age: " + dog.age);
            dog.Bark();
            dog.Eat();


            Rabbit rabbit = new Rabbit(3);
            rabbit.EatPlants();

            Console.ReadLine();

        }
    }
}
