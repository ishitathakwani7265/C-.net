// Write a program to calculate electricity bill based on unit slabs. Add a fixed meter charge and apply GST if the bill exceeds a certain amount.
// First 100 units → ₹1.5/unit
// Next 100 units → ₹2.5/unit
// Above 200 units → ₹4/unit
// Fixed meter charge → ₹50
// GST → 18% if bill > ₹500

using System;

class ElectricityBill
{
    static void Main()
    {
        int units;
        double bill = 0;

        Console.Write("Enter number of units: ");
        units = int.Parse(Console.ReadLine());

        if (units <= 100)
        {
            bill = units * 1.5;
        }
        else if (units <= 200)
        {
            bill = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else
        {
            bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        }

        bill = bill + 50;

        if (bill > 500)
        {
            bill = bill + (bill * 0.18);
        }

        Console.WriteLine("Total Electricity Bill: " + bill);
    }
}