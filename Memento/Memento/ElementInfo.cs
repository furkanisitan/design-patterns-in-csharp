namespace Memento
{
    class ElementInfo
    {
        public ElementType Type { get; set; }
        public string Detail { get; set; }
        public Location Location { get; set; }

        public ElementInfo() { }

        public ElementInfo(ElementType type, string detail, Location location)
        {
            Type = type;
            Detail = detail;
            Location = location;
        }
    }
}
