
namespace AbstractFactory
{
    public class OracleFactory : DBFactory
    {
        public override Command CreateCommand()
        {
            return new OracleCommand();
        }

        public override Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
