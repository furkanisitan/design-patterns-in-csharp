using Command.Commands;
using System;
using System.Collections;

namespace Command
{
    public class Shell
    {
        private Hashtable commands;

        private const string name = "FreeCSD";
        public string Name { get { return name; } }

        public string Version { get; set; } = "1.0.0.0";

        public Shell()
        {
            Console.Clear();
            Console.WriteLine($"{Name} ver: {Version}");
            Console.WriteLine("=====================");
            Console.Beep(440, 1500);

            commands = new Hashtable()
            {
                { "lst", new ListCommand() },
                { "crd", new MakeDirCommand() },
                { "dlt", new DelCommand() },
                { "quit", new QuitCommand() }
            };
        }

        public void CommandText()
        {
            Console.Write("> ");
            string cmdtxt = Console.ReadLine();
            string[] content = cmdtxt.Split(' ');

            if (content.Length == 1)
                AcceptCommand(content[0], "");
            else if (content.Length == 2)
                AcceptCommand(content[0], content[1]);
            else
                Console.WriteLine("Bad command!");
        }

        private void AcceptCommand(string cmd, string path)
        {
            if (commands.ContainsKey(cmd))
            {
                Commands.Command cmnd = (Commands.Command)commands[cmd];
                cmnd.Path = path;
                cmnd.Execute();
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Bad command!");
            }
        }
    }
}
