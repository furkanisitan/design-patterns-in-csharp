using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton4 obj1 = Singleton4.getObject;
            Singleton4 obj2 = Singleton4.getObject;

            Console.WriteLine(obj1.getNum());
            Console.WriteLine(obj2.getNum());
            Console.ReadKey();
        }
    }
}
