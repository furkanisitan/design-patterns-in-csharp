namespace HandleExpenseExample
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase successor;

        public abstract void HandleExpense(Expense expense);

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            this.successor = successor;
        }
    }
}
