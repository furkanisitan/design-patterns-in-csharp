using System;
using Visitor.Controls;

namespace Visitor.Visitors
{
    public class StateFullVisitor : IVisitor
    {
        public void Visit(Control control)
        {
            if (control is DropDownList)
                Console.WriteLine("Dropdown'a viewstate eklendi.");
            else if (control is Panel)
                Console.WriteLine("Panel'e viewstate eklendi.");
            else
                Console.WriteLine($"{control.GetType().Name}'a viewstate özelliği eklenemez.");
        }
    }
}
