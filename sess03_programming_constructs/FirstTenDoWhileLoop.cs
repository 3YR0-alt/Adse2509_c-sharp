using System;

namespace sess03_programming_constructs
{
    public class FirstTenDoWhileLoop
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float average;
            int n = 1; //Looping variable
            do
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
            } while (n <= 10);
            average = sum / (float)10;//Compute mean/average
                                      //Display the results
            Console.Write($"The sum of the first ten integers is "
                    + sum + " and their average is {0:2n}\n", average);
        }
    }
}
