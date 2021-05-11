using Generics.Entities;
using System;

namespace Generics
{
    class Program
    {
        public static PetStore<Dog> Dogs = new PetStore<Dog>();
        public static PetStore<Cat> Cats = new PetStore<Cat>();
        public static PetStore<Fish> Fishes = new PetStore<Fish>();
        static void Main(string[] args)
        {
            Dog dog1 = new Dog()
            {
                Name = "Bubi",
                Type = "Dog",
            };
            Dog dog2= new Dog()
            {
                Name = "Ben",
                Type = "Dog",
            };
            Cat cat1 = new Cat()
            {
                Name = "Maca",
                Type = "Cat",
            };
            Cat cat2 = new Cat()
            {
                Name = "Garfield",
                Type = "Cat",
            };
            Fish fish1 = new Fish()
            {
                Name = "Nemo",
                Type = "Fish",
            };
            Fish fish2 = new Fish()
            {
                Name = "Riki",
                Type = "Fish",
            };

            Dogs.Insert(dog1);
            Dogs.Insert(dog2);
            Cats.Insert(cat1);
            Cats.Insert(cat2);
            Fishes.Insert(fish1);
            Fishes.Insert(fish2);

            foreach (var fish in Fishes.Pets)
            {
                Console.WriteLine(fish.PrintInfo());
            }
            Dogs.Pets.ForEach(dog => Console.WriteLine(dog.PrintInfo()));
            Cats.Pets.ForEach(cat => Console.WriteLine(cat.PrintInfo()));
            Cats.BuyPet("Ma");
            Cats.Pets.ForEach(cat => Console.WriteLine(cat.PrintInfo()));

        }
    }
}
