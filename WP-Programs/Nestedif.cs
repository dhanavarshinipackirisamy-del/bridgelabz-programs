using System;

class User
{
    public bool IsActive { get; set; }
    public int Age { get; set; }
    public bool HasLicense { get; set; }
}

class Nestedif
{
    static void Main()
    {
        User user = new User { IsActive = true, Age = 22, HasLicense = true };
        CheckEligibility(user);
    }

    static void CheckEligibility(User user)
    {
        // Early return for invalid conditions
        if (user == null) return;
        if (!user.IsActive) return;
        if (user.Age < 18) return;
        if (!user.HasLicense) return;

        Console.WriteLine("User is eligible");
    }
}
