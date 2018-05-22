
namespace CarProductionExample
{
    class BmwFactory : Factory
    {
        private Bmw bmw = new Bmw();

        public override void AddPart(string part)
        {
            bmw.OptionallyParts.Add(part);
        }

        public override Car Produce(string model)
        {
            bmw.Model = model;
            return bmw;
        }
    }
}
