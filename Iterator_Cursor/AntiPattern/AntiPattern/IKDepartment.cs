
namespace AntiPattern
{
    class IKDepartment
    {
        private Employee[] employees;

        public IKDepartment()
        {
            employees = new Employee[]
            {
                new Employee("Furkan",22),
                new Employee("Example",32),
                new Employee("Test",44)
            };
        }

        public Employee[] GetEmployees()
        {
            return employees;
        }
       
    }
}
