namespace Decorator.Abstract
{
    public abstract class Window
    {
        public string Title { get; set; }

        protected Window() => Title = string.Empty;

        protected Window(string title) => Title = title;

        public abstract void Render();
    }
}
