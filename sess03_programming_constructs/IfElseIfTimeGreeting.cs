using System;

namespace sess03_programming_constructs
{
    public class IfElseIfTimeGreeting
    {
        /// <summary>
        /// Demonstrates the use of if, else if and else statements to greet a user
        /// according to the hour of the day.
        /// </summary>
        /// <remarks>
        /// The program prompts the user to enter their name and an hour between
        /// 0 and 23. It then displays an appropriate greeting based on the
        /// supplied hour:
        /// - Good morning for hours from 0 to 11.
        /// - Good afternoon for hours from 12 to 17.
        /// - Good evening for hours from 18 to 21.
        /// - Good night for hours from 22 to 23.
        /// </remarks>
        static void Main()
        {
            //Variable to hold the user's name
            string? name = "username";

            //Get the current hour from the system
            //uint currentHour = (uint)DateTime.Now.Hour;

            // Read in the user's name
            Console.WriteLine("Please enter your name ");
            name = Console.ReadLine();

            // Read in the current hour
            Console.WriteLine("Please enter the current hour of the day");
            uint currentHour = Convert.ToUInt32(Console.ReadLine());

            // Greet the user based on the hour of the day
            if (currentHour >= 0 && currentHour <= 11)
            {
                Console.WriteLine($"Good morning, {name}!");
            }
            else if (currentHour >= 12 && currentHour <= 17)
            {
                Console.WriteLine($"Good afternoon, {name}!");
            }
            else if (currentHour >= 18 && currentHour <= 21)
            {
                Console.WriteLine($"Good evening, {name}!");
            }
            else
            {
                Console.WriteLine($"Good night, {name}!");
            }
        }
    }
}
