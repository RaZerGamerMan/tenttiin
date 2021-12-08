using System;

namespace ExerciseTestQ2
{
    abstract class Character
    {
        private int x = 0, y = 0;
        private int maxbounds = 10;

        protected Character(int x, int y)
        {
            SetLocation(x, y);
        }

        public abstract void Speak();

        public void SetLocation(int x, int y)
        {
            if ((x < -maxbounds || x > maxbounds) || (y < -maxbounds || y > maxbounds))
            {
                Console.WriteLine("{0} objects new location was out of bounds.", this.GetType());
                return;
            }

            this.x = x;
            this.y = y;
            Console.WriteLine("{0} moved to location {1}", this.GetType().Name, GetLocation());
        }
        public string GetLocation()
        {
            return ($"({x},{y})");

        }

    }
    class Hero : Character
    {
        public string name;
        public int hp;
        public Hero(string name, int hp, int x, int y) : base(x, y) //koekysymys luultavasti
        {
            this.name = name;
            this.hp = hp;

        }
        public override void Speak()
        {
            Console.WriteLine("I will protect my city!");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
