using Visitor.Controls;

namespace Visitor.Visitors
{
    public interface IVisitor
    {
        void Visit(Control control);
    }
}