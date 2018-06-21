using SerializationLibExample.Strategy.Abstract;

namespace SerializationLibExample.Context
{
    class SerializationContext
    {
        private SerializationStrategy strategy;

        public SerializationContext(SerializationStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Save(string path)
        {
            strategy.Persist(path);
        }

        public object Load(string path)
        {
            return strategy.Load(path);
        }
    }
}
