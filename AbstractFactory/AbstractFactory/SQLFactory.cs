
namespace AbstractFactory
{
    public class SQLFactory : DBFactory
    {
        public override Command CreateCommand()
        {
            return new SQLCommand();
        }

        public override Connection CreateConnection()
        {
            return new SQLConnection();
        }
    }
}
