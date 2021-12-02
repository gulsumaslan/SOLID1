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
                Console.WriteLine("Köpekler havlayabilir");
            }

            public void Eat()
            {
                Console.WriteLine("Köpekler yemek yer.");
            }

            public void Respiratory()
            {
                Console.WriteLine("solunum yaparlar");
            }
        }
        public class Bird : IAnimals, IFly, ISpawn
        {
            public void Eat()
            {
                Console.WriteLine("Kuşlar yemek yer");
            }

            public void Fly()
            {
                Console.WriteLine("Kuşlar uçabilir");
            }

            public void Respiratory()
            {
                Console.WriteLine("solunum yaparlar");
            }

            public void Spawn()
            {
                Console.WriteLine("kuşlar yumurtlar");
            }
        }
        public class Cat : IMew, IAnimals
        {
            public void Eat()
            {
                Console.WriteLine("Kediler yemek yer");
            }

            public void Mew()
            {
                Console.WriteLine("Kediler miyavlar");
            }

            public void Respiratory()
            {
                Console.WriteLine("solunum yaparlar");
            }
        }
    }
}



