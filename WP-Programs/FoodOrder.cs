using System;

class FoodOrder
{
    static void Main()
    {
        
        bool restaurantOpen = true;       
        bool deliveryAvailable = true;    
        double orderAmount = 150;         
        bool isPrimeCustomer = true;      
        
        if (restaurantOpen && deliveryAvailable &&
            (orderAmount >= 200 || isPrimeCustomer))
        {
            Console.WriteLine("Order Accepted");
        }
        else
        {
            Console.WriteLine("Order Rejected");
        }
    }
}
