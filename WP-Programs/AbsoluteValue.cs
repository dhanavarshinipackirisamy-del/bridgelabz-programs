using System;

class AbsoluteValue
{
    static void Main()
    {
        int number = -10; // Change number to test
        int absoluteValue = (number >= 0) ? number : -number;
        Console.WriteLine("Absolute value of " + number + " is " + absoluteValue);
    }
}
