using Visitor.Visitors;

namespace Visitor.Controls
{
    public class Panel : Control
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
