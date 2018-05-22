
namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildPart(string partName);
        public abstract Product GetProduct();
    }
}
