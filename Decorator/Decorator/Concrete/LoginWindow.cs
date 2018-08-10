using Decorator.Abstract;
using System;

namespace Decorator.Concrete
{
    public class LoginWindow : Window
    {
        public LoginWindow() { }

        public LoginWindow(string title) : base(title) { }

        public override void Render() => Console.WriteLine($"'{Title}' titled login-window was rendered.");
    }
}
