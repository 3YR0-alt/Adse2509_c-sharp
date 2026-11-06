using System;

public class IfElseBatteryStatus
{
    static void Main(string[] args)
    {
        // Prompt the user of the percentage charge remaining in their battery
        Console.WriteLine("Please enter the percentage charge left in your phone's battery:");

        uint remainingCharge = Convert.ToUInt32(Console.ReadLine());

        if (remainingCharge > 20)
        {
            Console.WriteLine($"At {remainingCharge}%, your battery is OK 🆗");
        }
        else
        {
            Console.WriteLine($"At {remainingCharge}%, please recharge your battery 🔋");
        }
    }
}
