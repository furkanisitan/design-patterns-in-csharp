using System.Collections.Generic;

namespace ObjectPool
{
    public class PoolManager
    {
        private const int POOL_SIZE = 10;
        protected static volatile PoolManager poolManager;
        private Dictionary<string, List<ConnectionContext>> pools;

        protected PoolManager()
        {
            pools = new Dictionary<string, List<ConnectionContext>>(POOL_SIZE);
        }

        // Singleton
        private static object lockObj = new object();
        public static PoolManager getPool
        {
            get
            {
                if (poolManager == null)
                    lock (lockObj)
                        if (poolManager == null)
                            poolManager = new PoolManager();
                return poolManager;
            }
        }

        public ConnectionContext TakeConnection(string key)
        {
            if (pools.ContainsKey(key))
            {
                List<ConnectionContext> objects = pools[key];
                foreach (ConnectionContext connectionContext in objects)
                {
                    if (!connectionContext.IsActive)
                        return connectionContext;
                }
            }
            else
            {
                List<ConnectionContext> newPool = new List<ConnectionContext>(POOL_SIZE);
                for (int i = 0; i < POOL_SIZE; i++)
                {
                    newPool.Add(new ConnectionContext());
                }
                pools.Add(key, newPool);

                ConnectionContext connectionContext = newPool[0];
                connectionContext.IsActive = true;

                return connectionContext;
            }
            return null;
        }

        public void ReleaseConnection(ConnectionContext connection)
        {
            connection.IsActive = false;
        }
    }
}
