
namespace CarProductionExample
{
    class AudiFactory : Factory
    {
        private Audi audi = new Audi();

        public override void AddPart(string part)
        {
            audi.OptionallyParts.Add(part);
        }

        public override Car Produce(string model)
        {
            audi.Model = model;
            return audi;
        }
    }
}
