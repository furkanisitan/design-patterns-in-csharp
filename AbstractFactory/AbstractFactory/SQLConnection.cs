using System;

namespace AbstractFactory
{
    public class SQLConnection : Connection
    {
        public override string ConnectionString { get => connectionString; set => connectionString = value; }

        public override void Connect()
        {
            Console.WriteLine("Connected to SQL");
        }

    }
}
