using System.Collections.Generic;

namespace AntiPattern
{
    class ADKDepartment
    {
        private List<Employee> employees;

        public ADKDepartment()
        {
            employees = new List<Employee>()
            {
                new Employee("Furkan",22),
                new Employee("Test",32),
                new Employee("Example",44),
                new Employee("User",35)
            };
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
