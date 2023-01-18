using System;

namespace SOLID1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();
            dog.Respiratory();


            Console.WriteLine("-------------");

            Bird bird = new Bird();
            bird.Fly();
            bird.Eat();
            bird.Respiratory();
            bird.Spawn();

            Console.WriteLine("---------------");

            Cat cat = new Cat();
            cat.Mew();
            cat.Eat();
            cat.Respiratory();


            Console.ReadLine();


        }
        public interface IAnimals
        {
            void Eat();
            void Respiratory();


        }
        public interface IBark

        {
            void Bark();
        }

        public interface IFly
        {
            void Fly();

        }
        public interface IMew
        {
            void Mew();
        }
        public interface ISpawn
        {
            void Spawn();
        }


        public class Dog : IAnimals, IBark
        {
            public void Bark()
            {
                Console.WriteLine("dogs can bark");
            }

            public void Eat()
            {
                Console.WriteLine("dogs eat.");
            }

            public void Respiratory()
            {
                Console.WriteLine("they breathe");
            }
        }
        public class Bird : IAnimals, IFly, ISpawn
        {
            public void Eat()
            {
                Console.WriteLine("birds eat");
            }

            public void Fly()
            {
                Console.WriteLine("Birds can fly");
            }

            public void Respiratory()
            {
                Console.WriteLine("they breathe");
            }

            public void Spawn()
            {
                Console.WriteLine("birds lay eggs");
            }
        }
        public class Cat : IMew, IAnimals
        {
            public void Eat()
            {
                Console.WriteLine("cats eat");
            }

            public void Mew()
            {
                Console.WriteLine("cats meow");
            }

            public void Respiratory()
            {
                Console.WriteLine("they breathe");
            }
        }
    }
}



