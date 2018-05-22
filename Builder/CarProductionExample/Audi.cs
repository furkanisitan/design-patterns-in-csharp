
namespace CarProductionExample
{
    class Audi : Car
    {
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Audi() : base() { }

        public override string ToString()
        {
            return HelperClass.ToStringByBrand("AUDI", Model, CompulsoryParts, OptionallyParts);
        }
    }
}
