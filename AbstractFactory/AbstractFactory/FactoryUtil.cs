
namespace AbstractFactory
{
    class FactoryUtil
    {
        public static DBFactory GetFactory(string dbName)
        {
            if (dbName == "SQL")
                return new SQLFactory();
            if (dbName == "Oracle")
                return new OracleFactory();
            return null;
        }
    }
}
