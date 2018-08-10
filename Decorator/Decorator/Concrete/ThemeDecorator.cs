using Decorator.Abstract;
using System;

namespace Decorator.Concrete
{
    public class ThemeDecorator:WindowDecorator
    {
        public ThemeDecorator(Window targetWindow, string title) : base(targetWindow, title) { }

        public override void Render() => TargetWindow.Render();

        public void SetTheme(string name)
        {
            Console.WriteLine($"'{name}' theme was applied to '{Title}' titled window.");
            Render();
        }
    }
}
