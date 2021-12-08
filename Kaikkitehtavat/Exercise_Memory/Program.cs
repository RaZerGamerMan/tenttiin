using System;

namespace Exercise_Memory
{
    class GameObject
    {
        static GameObject()
        {
            Console.WriteLine("New game object created!");
        }
    }

    class Scene
    {
        private GameObject object1 = null;
        private GameObject object2 = null;
        private bool IsRunning = false;

        public Scene()
        {
            Init();
        }
        public void Init()
        {
            object1 = new GameObject();
            object2 = new GameObject();
            IsRunning = true;
        }
        public void Run()
        {
            Console.WriteLine("Game on!");
            while (IsRunning)
            {
                Console.WriteLine("Updating....");
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Scene gameScene = new Scene();
            gameScene.Run();
        }
    }
}

