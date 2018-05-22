
namespace FactoryMethod
{
    // FactoryMethod paterninin kullanım gerekçelerinden birisi de bazen sadece okunabilirliği arttırmaktır.

    // Örn: Aynı türde, fakat değerlere göre değişik şekillerde nesne yaratılmak istenirse aşağıdaki 
    //  gibi bir kod örmeği yapılabilir.

    class Sample
    {
        private Sample() {}

        public static Sample createSampleA(int a)
        {
            // factory1
            return new Sample();
        }

        public static Sample createSampleB(int b)
        {
            // factory2
            return new Sample();
        }

        public static Sample createSampleC(int c)
        {
            // factory3
            return new Sample();
        }

    }
}
