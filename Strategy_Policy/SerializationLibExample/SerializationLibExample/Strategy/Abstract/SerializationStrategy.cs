using System;

namespace SerializationLibExample.Strategy.Abstract
{
    abstract class SerializationStrategy
    {
        protected object graph;
        protected Type type;

        protected SerializationStrategy(object graph)
        {
            this.graph = graph;
            type = this.graph.GetType();
        }

        public abstract void Persist(string path);
        public abstract object Load(string path);
    }
}
