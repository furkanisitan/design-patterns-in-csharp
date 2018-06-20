using System;
using Visitor.Controls;

namespace Visitor.Visitors
{
    public class ControlsVisitor : IVisitor
    {
        public void Visit(Control control)
        {
            if (control is Panel)
                Console.WriteLine("Panel'e child eleman eklendi.");
            else
                Console.WriteLine($"{control.GetType().Name}'a child eleman eklenemez.");
        }
    }
}
