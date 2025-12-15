using System;

class SquareSide
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the perimeter:");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;

        Console.WriteLine(
            $"The length of the side is {side} whose perimeter is {perimeter}"
        );
    }
}
