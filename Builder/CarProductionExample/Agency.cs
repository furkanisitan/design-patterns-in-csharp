
namespace CarProductionExample
{
    class Agency
    {
        static Factory factory;

        public Audi AudiRequest(string model, params string[] requestParts)
        {
            factory = new AudiFactory();
            return (Audi)Request(model, requestParts);
        }

        public Bmw BmwRequest(string model, params string[] requestParts)
        {
            factory = new BmwFactory();
            return (Bmw)Request(model, requestParts);
        }

        private Car Request(string model, params string[] requestParts)
        {
            foreach (var request in requestParts)
                factory.AddPart(request);
            return factory.Produce(model);
        }
    }
}
