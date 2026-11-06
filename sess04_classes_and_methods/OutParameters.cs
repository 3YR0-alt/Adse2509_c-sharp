using System;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Demonstrates the use of the 'out' keyword in C# to pass an argument by reference,
    /// allowing a method to initialise and assign a valu to a variable declared in the calling method
    /// </summary>
    public class OutParameters
    {
        static void Depreciation(out int value)
        {
            //Assign the initial value of the object
            value = 40000;

            //Display the initial value of the object.
            Console.WriteLine($"Initial value of the object: {value}");

            //Calculate the depreciation amount at a rate of 20%
            int dep = value * 20 / 100;

            //Calculate the reduced value after depreciation
            int amount = value - dep;

            //Display the depreciation amount and the final value of the object
            Console.WriteLine($"The depreciation amount: {dep}" + 
                $"\nThe reduced value after depriciation: {amount}");
        }

        static void Main()
        {
            //Declare an integer variable without initialising it.
            int value;

            //Invoke the 'Depreciation()' method, passing the variable 'value' as an 'out' parameter.
            Depreciation(out value);
        }
    }
}
