using System;

namespace GitProgram
{
    class PaymentService
    {
        public bool ProcessPayment(int amount)
        {
            // Validation from branch 1
            if (amount <= 0)
                return false;

            // Return logic from branch 2
            return amount > 0;
        }
    }
}
