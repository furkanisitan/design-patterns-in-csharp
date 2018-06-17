namespace Command.Commands
{
    public abstract class Command
    {
        public abstract string Path { get; set; }

        public abstract void Execute();
    }
}
