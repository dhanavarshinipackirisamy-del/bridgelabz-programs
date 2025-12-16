using System;

class Program
{
    static void Main()
    {
        int number = 15; // Change number to test

        if ((number % 3 == 0) ^ (number % 5 == 0)) // ^ is XOR operator
        {
            Console.WriteLine(number + " is divisible by 3 or 5 but not both.");
        }
        else
        {
            Console.WriteLine(number + " is either divisible by both or neither.");
        }
    }
}
