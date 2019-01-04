using System;

namespace Adapter
{
    class EntityManager
    {
        private readonly ILogger _logger;

        public EntityManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log("Added");
            Console.WriteLine("Entity Added");
        }

    }
}
