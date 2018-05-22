
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramRun.run();

            Console.ReadKey();
            Console.WriteLine("\n\n--------------------------------\n\nCar Production Example\n\n\n");

            CarProductionExample.ProgramRun.run();

            Console.ReadKey();
        }
    }
}
