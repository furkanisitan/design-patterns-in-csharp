using Decorator.Abstract;
using System;

namespace Decorator.Concrete
{
    public class ReportWindow : Window
    {
        public ReportWindow() { }

        public ReportWindow(string title) : base(title) { }

        public override void Render() => Console.WriteLine($"'{Title}' titled report-window was rendered.");
    }
}
