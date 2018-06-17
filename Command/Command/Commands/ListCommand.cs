namespace Command.Commands
{
    public sealed class ListCommand : Command
    {
        private Kernel kernel = new Kernel();
        private string path;

        public override string Path { get => path; set => path = value; }

        public override void Execute()
        {
            kernel.DirListAPI(path);
        }
    }
}