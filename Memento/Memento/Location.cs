namespace Memento
{
    class Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"X: {X} - Y: {Y}";
    }
}
