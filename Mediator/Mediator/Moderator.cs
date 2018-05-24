using System;

namespace Mediator
{
    class Moderator : Subscriber
    {
        public Moderator(string nick) : base(nick) { }

        public override void GetMessage(Subscriber sender, string message)
        {
            Console.WriteLine($"{sender.Nick} -> {Nick} : {message}");
        }
    }
}
