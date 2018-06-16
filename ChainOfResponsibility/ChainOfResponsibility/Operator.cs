using System;

namespace ChainOfResponsibility
{
    public class Operator
    {
        public Operator Next { get; set; }
        public bool State { get; set; }
        public string Name { get; set; }

        public Operator(string name)
        {
            Name = name;
        }

        public void AnswerCall()
        {
            if (State)
            {
                // cevapla
                Console.Write($"{Name} çağrıyı cevapladı");
            }
            else if (Next != null)
            {
                // sonrakine ilet
                Next.AnswerCall();
            }
            else
            {
                Console.Write("Çağrı beklemede");
            }
        }

    }
}
