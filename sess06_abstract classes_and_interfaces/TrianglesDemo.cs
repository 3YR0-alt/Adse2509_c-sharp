using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace sess06_abstract_classes_and_interfaces
{
    public class TrianglesDemo
    {
        private static byte GetPositiveDimensions(String dimensionName)
        {
            byte dimension;
            while(true)
            {
                Console.WriteLine($"Enter the triangle's {dimensionName} (1 - 255): ");
                string? input = Console.ReadLine();
                if (byte.TryParse(input, out dimension) && dimension > 0)
                {
                    return dimension;
                }
                Console.WriteLine($"Invalid {dimensionName}. Please enter a  positive whole" +
                    $"number between 1 and 255.\n");
            }
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("          TRIANGLES DEMONSTRATION");
            Console.WriteLine(new string('=', 60));

            //Obtain valid dimensions from the user for the right-angled triangle
            byte height = GetPositiveDimensions("height");
            byte @base = GetPositiveDimensions("base");

            //Create a right-angled triangle object using dimensions supplied by the user
            RightAngledTriangle tr1 = new RightAngledTriangle(height, @base);

            //Create a Scalene triangle using hard-coded values. the values used
            //to satisfy the triangle inequality theorem (a + b > c) are: 3, 4, 5
            ScaleneTriangle sc1 = new ScaleneTriangle(5, 6, 7);

            //Display the dimensions and calculated properties of the right-angled triangle.
            // Display the dimensions and calculated properties of the right-angled triangle.
            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("          RIGHT-ANGLED TRIANGLE");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine(tr1);

            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("          SCALENE TRIANGLE");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine(sc1);

        }
    }
}
