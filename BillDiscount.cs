// Write a program that calculates bill and gives discount based on customer category (senior citizen, regular, industrial).
using System;

class BillDiscount
{
    static void Main()
    {
        double bill, discount = 0, finalBill;
        string category;

        Console.Write("Enter bill amount: ");
        bill = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter customer category: ");
        category = Console.ReadLine();

        if (category == "senior citizen")
        {
            discount = bill * 20 / 100;
        }
        else if (category == "regular")
        {
            discount = bill * 10 / 100;
        }
        else if (category == "industrial")
        {
            discount = bill * 15 / 100;
        }

        finalBill = bill - discount;

        Console.WriteLine("Discount = " + discount);
        Console.WriteLine("Final Bill = " + finalBill);
    }
}