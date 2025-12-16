using System;

class PositiveOrNegative
{
    static void Main()
    {
        int number = 10;

        string result = Math.Sign(number) == 1 ? "Positive" :
                        Math.Sign(number) == -1 ? "Negative" : "Zero";

        Console.WriteLine(result);
    }
}
