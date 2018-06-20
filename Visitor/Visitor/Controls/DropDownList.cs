using Visitor.Visitors;

namespace Visitor.Controls
{
    public class DropDownList : Control
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
