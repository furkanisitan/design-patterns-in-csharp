using System;
using System.Collections.Generic;

namespace Prototype
{
    public class Database : ICloneable
    {
        public string Name { get; set; }
        private List<string> Tables { get; set; }

        public Database()
        {
            Name = "Model";
            Tables = new List<string>();
            Tables.AddRange(new string[] { "sysusers", "sysindexes", "sysfiles" });
        }

        public void AddTable(string name)
        {
            Tables.Add(name);
        }

        public void TableList()
        {
            foreach (var item in Tables)
                Console.WriteLine(item);
        }

        // Klonlama işlemi
        public object Clone()
        {
            return new Database();
        }
    }
}
