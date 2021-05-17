using LinqHomework.Data;
using LinqHomework.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHomework.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            Console.WriteLine("Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER");
            Console.WriteLine("=============================");
            List<Person> namesWithR = DB.People.Where(person => person.FirstName.StartsWith("R")).OrderByDescending(person => person.Age).ToList();
            namesWithR.ForEach(person => Console.WriteLine($"{person.FirstName} - Age: {person.Age}"));            
            Console.WriteLine("=============================");
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            List<Dog> brownDogs = DB.Dogs.Where(dog => dog.Color == "Brown" && dog.Age > 3).OrderBy(dog => dog.Age).ToList();
            Console.WriteLine("Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER");
            Console.WriteLine("=============================");
            brownDogs.ForEach(dog => Console.WriteLine($"Color: {dog.Color} - Age:{dog.Age}"));
            Console.WriteLine("=============================");
            // 3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            Console.WriteLine("Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");
            Console.WriteLine("=============================");
            var personWithTwoDogs = DB.People.Where(person => person.Dogs.Count > 2).OrderByDescending(person => person.FirstName).ToList();
            personWithTwoDogs.ForEach(person => Console.WriteLine($"{person.FirstName} -Number of Dogs: {person.Dogs.Count}"));
            Console.WriteLine("=============================");
            // 4. Find and print all Freddy`s dogs names older than 1 year
            Console.WriteLine("Find and print all Freddy`s dogs names older than 1 year");
            Console.WriteLine("=============================");
            var freddysDogs = DB.People.Where(person => person.FirstName == "Freddy").SelectMany(person => person.Dogs.Where(dog => dog.Age > 1)).ToList();
            freddysDogs.ForEach(dog => Console.WriteLine($"{dog.Name}"));
            Console.WriteLine("=============================");
            // 5. Find and print Nathen`s first dog
            Console.WriteLine("Find and print Nathen`s first dog");
            Console.WriteLine("=============================");
            var nathenFirstDog = DB.People.Where(person => person.FirstName == "Nathen").Select(person => person.Dogs.First()).ToList();
            nathenFirstDog.ForEach(dog => Console.WriteLine(dog.Name));
            Console.WriteLine("=============================");
            // 6. Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            Console.WriteLine("Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER");
            Console.WriteLine("=============================");
            var whiteDogs = DB.People.Where(person => person.FirstName == "Cristofer" || person.FirstName == "Freddy" || person.FirstName == "Erin" || person.FirstName == "Amelia")
                                     .SelectMany(person => person.Dogs.Where(dog => dog.Color == "White"))
                                     .OrderBy(dog => dog.Name).ToList();
            whiteDogs.ForEach(dog => Console.WriteLine($"{dog.Name} - Color: {dog.Color}"));
        }
    }
}
