
namespace AbstractFactory
{
    public abstract class Connection
    {
        public abstract void Connect();
        public abstract string ConnectionString { get; set; }
        protected string connectionString;
    }
}
