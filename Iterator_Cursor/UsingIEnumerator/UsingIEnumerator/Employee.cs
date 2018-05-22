
namespace UsingIEnumerator
{
    class Employee
    {
        private string name;
        private int age;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} : {age}";
        }
    }
}
