using SerializationLibExample.Context;
using SerializationLibExample.Strategy.Concrete;
using System.Data;
using System.Data.SqlClient;

namespace SerializationLibExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TableName", "server=.;database=Example;uid=fi;pwd=password");
            DataTable table = new DataTable();
            adapter.Fill(table);

            SerializationContext context = new SerializationContext(new XmlStrategy(table));
            context.Save("D:\\Dosya1.xml");

            table.RemotingFormat = SerializationFormat.Binary;

            context = new SerializationContext(new BinaryStrategy(table));
            context.Save("D:\\Dosya2.bin");

        }
    }
}
