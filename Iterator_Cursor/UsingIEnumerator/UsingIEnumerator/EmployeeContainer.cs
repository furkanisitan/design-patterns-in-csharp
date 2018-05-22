using System.Collections;

namespace UsingIEnumerator
{
    class EmployeeContainer : IEnumerable
    {
        public Employee[] Items { get; }

        public EmployeeContainer()
        {
            Items = new Employee[]
            {
                new Employee("Furkan",22),
                new Employee("Test1",24),
                new Employee("Test2",55),
                new Employee("Test3",18),
                new Employee("Test4",65)
            };
        }

        public IEnumerator GetEnumerator()
        {
            return new EmployeeIterator(this);
        }
    }
}
