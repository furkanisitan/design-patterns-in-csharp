using Strategy_Policy.Strategy.Abstract;
using System;

namespace Strategy_Policy.Strategy.Concrete
{
    class RadialGradienBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine("2 renkli yuvarlak geçişli boyama");
        }
    }
}
