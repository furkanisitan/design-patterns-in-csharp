using SerializationLibExample.Strategy.Abstract;
using System.IO;
using System.Xml.Serialization;

namespace SerializationLibExample.Strategy.Concrete
{
    sealed class XmlStrategy : SerializationStrategy
    {
        private XmlSerializer formatter;

        public XmlStrategy(object graph) : base(graph) => formatter = new XmlSerializer(type);

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

        ~XmlStrategy() => formatter = null;
    }
}
