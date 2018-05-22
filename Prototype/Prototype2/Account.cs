using System;

namespace Prototype2
{
    [Serializable]
    public class Account : PrototypeHelper<Account>
    {
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }

        public Account(decimal balance, string name, string surname)
        {
            Balance = balance;
            Customer = new Customer(name, surname);
        }

        public override string ToString()
        {
            return $"{Customer.ToString(),-20}{Balance}";
        }
    }
}
