using System;
using static sess10_generics_and_iterators.GenericClass;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// Program to demonstrate how to work with a user-defined/custom generic class.
    /// </summary>
    public class DemoGenericClass
    {
        static void Main(string[] args)
        {
            int n; // Looping variable

            // Declare value and reference types using the custom generic class.
            GenericClass<float> temps;
            GenericClass<string> computerGames;  // GenericClass<string> movies;GenericClass<string> series;
            GenericClass<Person> people;

            int numOfItems; // For generic item quantities

            // Prompt the user for the number of temperature
            Console.WriteLine("How many temperatures do you wish to store?");
            numOfItems = int.Parse(Console.ReadLine());
            // Instantiate the generic temperatures
            temps = new GenericClass<float>(numOfItems);

            // Use a for loop to read in the temperatures from the user
            for (n = 0; n < numOfItems; n++)
            {
                Console.WriteLine($"Please enter the value for temperature: {n + 1}");
                temps.AddItem(float.Parse(Console.ReadLine()));
            }

            // Display the temperatures entered by the user
            Console.WriteLine(temps);

            // TODO: Prompt the user for the number of games, movies, series they'd like
            // to store, read in and display them

            // Prompt the user for the number of people they'd like to store
            Console.WriteLine("How many people would you like to store?");
            numOfItems = int.Parse(Console.ReadLine());
            // Instantiate a generic class of Persons
            people = new GenericClass<Person>(numOfItems);
            // Read in the people's details
            for (n = 0; n < numOfItems; n++)
            {
                Console.WriteLine($"Please enter the name of person {n + 1}:");
                string name = Console.ReadLine();
                Console.WriteLine($"Please enter {name}'s birth date:");
                DateTime dob = DateTime.Parse(Console.ReadLine()); // DateTime dob = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine($"Please enter {name}'s binary gender (M/F)");
                char gender = char.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter {name}'s email address");
                string email = Console.ReadLine();
                Console.WriteLine($"Please enter {name}'s nationality");
                string nationality = Console.ReadLine();

                // Create/instantiate a new person and add them to the list of people
                people.AddItem(new Person(name, dob, gender, email, nationality));
            }

            // Display the details for each person 
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}