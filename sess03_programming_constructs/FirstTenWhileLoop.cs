using System;

namespace sess03_programming_constructs
{
    public class FirstTenWhileLoop
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float average;
            int n = 1; //Looping variable
            while (n <= 10)
            {
                if (n < 10)
                {
                    Console.Write(n + ", ");
                }
                else
                {
                    Console.Write(n + ".\n");
                }
                sum += n;
                n++;
            } 
            average = sum / (float)10;//Compute mean/average
                                      //Display the results
            Console.Write($"The sum of the first ten integers is "
                    + sum + " and their average is {0:2n}\n", average);
        }
    }
}
