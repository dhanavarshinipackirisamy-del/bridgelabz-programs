using System;

class Temperature
{
    static void Main()
    {
        int temperature = 25; 
        if (temperature < 0)
        {
            Console.WriteLine("Freezing");
        }
        else if (temperature <= 20)
        {
            Console.WriteLine("Cold");
        }
        else if (temperature <= 35)
        {
            Console.WriteLine("Warm");
        }
        else
        {
            Console.WriteLine("Hot");
        }
    }
}

