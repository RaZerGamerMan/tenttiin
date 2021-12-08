using System;
// Luo luokka Foo
// Luokalta löytyy funktio public void DoSomething()
// -tulosta funktiossa jotain konsoliin.

// Luo pääohjelmassa Foo taulukko, jonka koko on 10

// Luo 10 Foo oliota taulukon alkiohin, ja kutsu samalla DoSomething() funktiota.
namespace ExerciseTestQ
{
    class Program
    {
        class Foo
        {
            public void DoSomething()
            {
                Console.WriteLine("Do something!");
            }
        }
        static void Main(string[] args)
        {
            Foo[] foos = new Foo[10];

            for (int i = 0; i < foos.Length; i++)
            {
                foos[i] = new Foo();
                foos[i].DoSomething();
            }
        }
    }
}
