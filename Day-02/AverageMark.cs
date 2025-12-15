using System;

class AverageMark
{
    public static void Main(string[] args)
    {
        int maths = 94;
        int physics = 95;
        int chemistry = 96;

        int total = maths + physics + chemistry;
        double average = total / 3.0;

        Console.WriteLine($"Sam's average percent marks in PCM is {average}");
    }
}

