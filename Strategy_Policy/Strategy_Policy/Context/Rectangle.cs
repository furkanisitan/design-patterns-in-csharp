using Strategy_Policy.Strategy.Abstract;
using System;

namespace Strategy_Policy.Context
{
    class Rectangle
    {
        private Brush brush;

        public Rectangle()
        {

        }

        public Rectangle(Brush brush)
        {
            this.brush = brush;
        }

        public void Draw()
        {
            brush.Paint();
            Console.WriteLine("Dikdörtgen");
        }
    }
}