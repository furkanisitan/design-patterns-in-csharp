namespace Interpreter
{
    class ColorCode
    {
        public string Color { get; }
        public string Number { get; }

        public ColorCode(string number, string color)
        {
            Color = color;
            Number = number;
        }
    }
}
