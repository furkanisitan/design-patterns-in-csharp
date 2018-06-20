using BankCreditExample.Visitors;

namespace BankCreditExample.Customers
{
    public abstract class Customer
    {
        protected string name, surname;

        protected Customer(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
