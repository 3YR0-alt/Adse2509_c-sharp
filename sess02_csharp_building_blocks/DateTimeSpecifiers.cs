using System;

namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// program to demonstrate C#'s date and time format specifiers.
    /// </summary>
    public class DateTimeSpecifiers
    {
        static void Main(string[] args)
        {
            //Variable to hold the current date and time
            DateTime currentDateTime = DateTime.Now;

            //Standard date and time format specifiers
            Console.WriteLine("C# Standard Date & Time format specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Short date (d): {currentDateTime:d}");
            Console.WriteLine($"Long date (D): {currentDateTime:D}");
            Console.WriteLine($"General date (G): {currentDateTime:G}");
            Console.WriteLine($"Short time (t): {currentDateTime:t}");
            Console.WriteLine($"Long time (T): {currentDateTime:T}");
            Console.WriteLine($"RFC1123 (r): {currentDateTime:r}");
            Console.WriteLine($"Sortable (s): {currentDateTime:s}");
            Console.WriteLine($"Universal Sortable (u): {currentDateTime:u}");
            Console.WriteLine($"Day of the Month (M): {currentDateTime:M}");
            Console.WriteLine($"Month of the Year (y): {currentDateTime:y}");
            Console.WriteLine(new string('-', 70));
            

            //Custom date and time format specifiers
            Console.WriteLine("C# Custom Date & Time format specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Custom date (dd/MM/yyyy): {currentDateTime:dd/MM/yyyy}");
            Console.WriteLine($"Custom date (dd/MM/yyyy):" + currentDateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine($"Custom time with am/pm (hh:mm:ss tt): {currentDateTime:hh:mm:ss tt}");
            Console.WriteLine($"Custom date with the day of the week (dddd, dd, MMMM, yyyy): {currentDateTime:dddd, dd, MMMM, yyyy}");
            Console.WriteLine($"Custom time in 24-hour format (HH:mm:ss): {currentDateTime:HH:mm:ss}");
            Console.WriteLine($"Custom time in 24-hour format with milliseconds (HH:mm:ss.fff): {currentDateTime:HH:mm:ss.fff}");
            Console.WriteLine($"Custom date (day of the week & year) (ddd,yyyy): {currentDateTime:ddd,yyyy}");
            Console.WriteLine($"Custom date and time:\nDATE: (dd-MM-yyyy): {currentDateTime:dd-MM-yyyy}\nTime: (HH:mm:ss tt): {currentDateTime:HH:mm:ss tt}");
            Console.WriteLine($"Custom Day of the Month (M): {currentDateTime:M}");
            Console.WriteLine($"Custom time in 24-hour format with time zone (HH:mm:ss zzz): {currentDateTime:HH:mm:ss zzz}");
            Console.WriteLine(new string('-', 70));
        }
    }
}
