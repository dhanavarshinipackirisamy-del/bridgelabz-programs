using System;
using System.Text.RegularExpressions;

class PasswrdChecker
{
    static void Main()
    {
        string password = "Pass@123"; // Change password to test

        Console.WriteLine("Password: " + password);
        Console.WriteLine("Strength: " + CheckPasswordStrength(password));
    }

    static string CheckPasswordStrength(string password)
    {
        bool isLongEnough = password.Length >= 8;

        bool hasDigit = Regex.IsMatch(password, @"\d");

        bool hasSpecialChar = Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]");

        if (isLongEnough && hasDigit && hasSpecialChar)
        {
            return "Strong";
        }
        else if (isLongEnough && (hasDigit || hasSpecialChar))
        {
            return "Medium";
        }
        else
        {
            return "Weak";
        }
    }
}
