using Visitor.Visitors;

namespace Visitor.Controls
{
    public abstract class Control
    {
        public abstract void Accept(IVisitor visitor);

        public string Id { get; set; }
        public string Text { get; set; }
    }
}
