namespace Memento
{
    class Element
    {
        // state
        public ElementInfo ElementInfo { get; set; }

        public Element(ElementInfo elementInfo) => ElementInfo = elementInfo;

        public Memento CreateMemento() => new Memento(ElementInfo);

        public void SetMemento(Memento memento) => ElementInfo = memento.ElementInfo;

        public override string ToString() =>
            $"Eleman Details {{ Type: {ElementInfo.Type}, Detail: {ElementInfo.Detail}, Location: {ElementInfo.Location} }}";

    }
}
