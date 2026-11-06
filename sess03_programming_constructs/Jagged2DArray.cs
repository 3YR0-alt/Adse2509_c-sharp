using System;

namespace sess03_programming_constructs
{
    /// <summary>
    /// Program that demonstrates how to create and display the contents of a jagged array
    /// </summary>
    public class Jagged2DArray
    {
        static void Main(string[] args)
        {
            string[][] companies = new string[5][];
            {
                companies[0] = new string[5] { "Intel", "AMD", "NVIDIA" }; // Computer/desktop/laptop/server processors
                companies[1] = new string[5] { "Apple", "Samsung", "Google" }; // Mobile processors
                companies[2] = new string[5] { "IBM", "HP", "Dell" }; // Enterprise servers
                companies[3] = new string[5] { "Qualcomm", "MediaTek", "Spreadtrum" }; // Mobile chips
                companies[4] = new string[5] { "Fullstack", "Thorton", "Prozone", "AnySonic", "Makaa Base International" }; // Student manufacturers
            }

            //Display the contents of the jagged array
            for (int i = 0; i < companies.Length; i++)
            {
                Console.WriteLine($"Companies in category {i + 1}:");
                for (int j = 0; j < companies[i].Length; j++)
                {
                    Console.WriteLine($"- {companies[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
