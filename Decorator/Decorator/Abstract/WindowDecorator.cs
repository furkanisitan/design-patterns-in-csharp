namespace Decorator.Abstract
{
    public abstract class WindowDecorator : Window
    {
        public Window TargetWindow { get; set; }

        protected WindowDecorator(Window targetWindow, string title)
        {
            TargetWindow = targetWindow;
            Title = title;
        }
    }
}
