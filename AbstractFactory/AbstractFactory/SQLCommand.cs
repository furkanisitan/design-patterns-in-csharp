using System;

namespace AbstractFactory
{
    public class SQLCommand : Command
    {
        public override string Query { get => query; set => query = value; }

        public override void Execute()
        {
            Console.WriteLine("T-SQL worked");
        }
    }
}
