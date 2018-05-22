using System;

namespace AbstractFactory
{
    public class OracleCommand : Command
    {
        public override string Query { get => query; set => query = value; }

        public override void Execute()
        {
            Console.WriteLine("PL/SQL worked");
        }
    }
}
