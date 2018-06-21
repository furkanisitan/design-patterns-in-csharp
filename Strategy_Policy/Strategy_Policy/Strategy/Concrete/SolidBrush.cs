using Strategy_Policy.Strategy.Abstract;
using System;

namespace Strategy_Policy.Strategy.Concrete
{
    class SolidBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine("Tek renkli boyama");
        }
    }
}
