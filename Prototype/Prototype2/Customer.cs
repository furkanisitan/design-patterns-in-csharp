using System;

namespace Prototype2
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }

}
