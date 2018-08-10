using Decorator.Abstract;
using System;

namespace Decorator.Concrete
{
    public class ScrollDecorator : WindowDecorator
    {
        public ScrollDecorator(Window targetWindow, string title) : base(targetWindow, title) { }

        public override void Render() => TargetWindow.Render();

        public void ScrollBy(int amount)
        {
            Console.WriteLine($"{Title}' titled window has scrolled of {amount} units.");
            Render();
        }
    }
}
