using System;

class ATMChecker
{
    static void Main()
    {
        // Sample account balance
        double balance = 25000;
        double dailyLimit = 20000;

        
        double amount = 15000; 

        
        if (amount <= dailyLimit) 
        {
            if (amount <= balance - 1000) 
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful!");
                Console.WriteLine("Remaining Balance: ₹" + balance);
            }
            else
            {
                Console.WriteLine("Withdrawal Rejected: Insufficient balance to maintain minimum ₹1000.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal Rejected: Amount exceeds daily limit of ₹" + dailyLimit);
        }
    }
}
