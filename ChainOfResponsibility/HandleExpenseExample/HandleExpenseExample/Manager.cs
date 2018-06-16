using System;

namespace HandleExpenseExample
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount < 100)
                Console.WriteLine("Manager handled the expense!");
            else if (successor != null)
                successor.HandleExpense(expense);
        }
    }
}
