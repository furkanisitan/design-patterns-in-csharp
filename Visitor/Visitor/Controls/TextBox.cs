using Visitor.Visitors;

namespace Visitor.Controls
{
    public class TextBox : Control
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
