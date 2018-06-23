namespace Memento
{
    class Memento
    {
        // state
        public ElementInfo ElementInfo { get; set; }

        public Memento(ElementInfo elementInfo)
        {
            ElementInfo = elementInfo;
        }
    }
}
