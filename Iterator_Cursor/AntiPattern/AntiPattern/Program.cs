using System;
using System.Collections.Generic;

namespace AntiPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IKDepartment ik = new IKDepartment();
            Employee[] array = ik.GetEmployees();

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i].ToString());

            Console.WriteLine("---------------------------------------");
            
            // Farklı yöntem kullanılmak zorunda kalınmış.

            ADKDepartment adk = new ADKDepartment();
            List<Employee> list = adk.GetEmployees();

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i].ToString());

            Console.ReadKey();

        }
    }
}
