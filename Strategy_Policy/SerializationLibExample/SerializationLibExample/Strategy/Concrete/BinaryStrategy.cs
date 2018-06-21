using SerializationLibExample.Strategy.Abstract;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationLibExample.Strategy.Concrete
{
    sealed class BinaryStrategy : SerializationStrategy
    {
        private BinaryFormatter formatter;

        public BinaryStrategy(object graph) : base(graph) => formatter = new BinaryFormatter();

        public override object Load(string path)
        {
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                object tmp = formatter.Deserialize(fs);
                return tmp;
            }
        }

        public override void Persist(string path)
        {
            using (FileStream fs = File.Create(path))
                formatter.Serialize(fs, graph);
        }

        ~BinaryStrategy() => formatter = null;

    }
}
