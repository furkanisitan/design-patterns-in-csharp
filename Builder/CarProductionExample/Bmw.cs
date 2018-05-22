
namespace CarProductionExample
{
    class Bmw : Car
    {
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Bmw() : base() { }

        public override string ToString()
        {
            return HelperClass.ToStringByBrand("BMW",Model,CompulsoryParts,OptionallyParts);
        }

    }
}
