
using System;

namespace ObjectPool
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        private PoolManager poolManager;
        private ConnectionContext connectionContext;

        public Connection(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public void Open()
        {
            poolManager = PoolManager.getPool;
            connectionContext = poolManager.TakeConnection(ConnectionString);
            if (connectionContext != null)
                connectionContext.Open();
            else
                Console.WriteLine("Havuzda uygun nesne yok");
        }

        public void Close()
        {
            poolManager.ReleaseConnection(connectionContext);
            connectionContext.Close();
        }

        public void Execute(string query)
        {
            connectionContext.Execute(query);
        }

    }
}
