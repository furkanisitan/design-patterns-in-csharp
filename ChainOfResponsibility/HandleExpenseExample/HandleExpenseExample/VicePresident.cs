using System;

namespace HandleExpenseExample
{
    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount >= 100 && expense.Amount < 1000)
                Console.WriteLine("Vice President handled the expense!");
            else if (successor != null)
                successor.HandleExpense(expense);
        }
    }
}
