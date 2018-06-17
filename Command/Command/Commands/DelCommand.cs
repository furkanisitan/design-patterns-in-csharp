namespace Command.Commands
{
    public sealed class DelCommand : Command
    {
        private Kernel kernel = new Kernel();
        private string path;

        public override string Path { get => path; set => path = value; }

        public override void Execute()
        {
            kernel.DeleteAPI(path);
        }
    }
}