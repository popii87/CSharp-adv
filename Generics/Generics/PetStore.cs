using Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets;
        public PetStore()
        {
            Pets = new List<T>();
        }
        public void Insert(T item)
        {
            Pets.Add(item);
        }
        public void PrintPets()
        {
            foreach (T item in Pets)
            {
                Console.WriteLine($"{item.PrintInfo()}");
            }
        }
        public  void BuyPet (string name)
        {
            foreach (T item in Pets)
            {
                if (name != item.Name)
                {
                    Console.WriteLine($"Sorry we dont have Pet {name} in our store");
                    
                }
                return;
            }
            T boughtPet = Pets.Where(pet => pet.Name == name).FirstOrDefault();
            Pets.Remove(boughtPet);
            Console.WriteLine($"Congratz you bought {boughtPet.PrintInfo()}");
            
        }
    }
}
