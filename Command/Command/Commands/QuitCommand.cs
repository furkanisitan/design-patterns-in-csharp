namespace Command.Commands
{
    public sealed class QuitCommand : Command
    {
        private Kernel kernel = new Kernel();

        public override string Path { get => ""; set { } }

        public override void Execute()
        {
            kernel.QuitAPI();
        }
    }
}