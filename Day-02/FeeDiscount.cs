using System;
using System;

class CourseFeeDiscountInput
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the course fee:");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the discount percentage:");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;

        Console.WriteLine(
            $"The discount amount is INR {discount} and final discounted fee is INR {finalFee}"
        );
    }
}

