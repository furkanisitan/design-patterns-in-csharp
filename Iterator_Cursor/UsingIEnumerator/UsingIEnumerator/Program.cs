using System;

namespace UsingIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeContainer container = new EmployeeContainer();

            foreach (Employee item in container)
                Console.WriteLine(item.ToString());

            Console.WriteLine("------------------------------------");
            EmployeeIterator iter = (EmployeeIterator)container.GetEnumerator();

            while (iter.MoveNext())
                Console.WriteLine(((Employee)iter.Current).ToString());

            Console.ReadKey();
        }
    }
}
