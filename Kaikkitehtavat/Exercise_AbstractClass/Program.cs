using System;

namespace Exercise_AbstractClass
{
    abstract class AbstractFoo
    {
        public abstract void DoSomething();
        public virtual int Plus(int a, int b)
        {
            return 0;
        }
    }
    class Foo : AbstractFoo
    {
        public override void DoSomething()
        {
            Console.WriteLine("Do something now");
        }
        public override int Plus(int a, int b)
        {
            {
                return a + b;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Foo foo = new Foo();
                foo.DoSomething();
                Console.WriteLine(foo.Plus(1, 3).ToString());
            }
        }
    }
}
