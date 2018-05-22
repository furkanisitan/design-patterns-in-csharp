
namespace Builder
{
    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPart(string partName)
        {
            product.Add(partName);
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}
