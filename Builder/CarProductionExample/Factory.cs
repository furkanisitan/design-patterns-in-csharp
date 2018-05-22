
namespace CarProductionExample
{
    abstract class Factory
    {
        public abstract void AddPart(string part);
        public abstract Car Produce(string model);
    }
}
