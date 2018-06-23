namespace Interpreter.Context
{
    class Resistance
    {
        public string Input { get; }
        public string Output { get; set; }
        public string[] Bands { get; }

        public Resistance(string input)
        {
            Input = input;
            Bands = input.Split('-');
        }
    }
}
