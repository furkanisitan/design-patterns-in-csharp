using System;

namespace Prototype
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Property1\n");

            Client.run();

            Console.WriteLine("\n\nProperty2\n");

            Prototype2.Client.run();

        }

    }
}
