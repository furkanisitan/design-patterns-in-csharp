using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class CallCenter
    {
        private List<Operator> agents = new List<Operator>();

        public CallCenter()
        {
            Operator[] operators = {
                new Operator("Furkan") { State=false,},
                new Operator("Metin") { State=false},
                new Operator("Ali") { State=true},
                new Operator("Feyyaz") { State=false}
            };
            for (int i = 0; i < operators.Length; i++)
                operators[i].Next = operators[i] == operators[operators.Length - 1] ? null : operators[i + 1];

            agents.AddRange(operators);
        }

        public void GetCall()
        {
            // ilk operatöre görevi ver
            agents[0].AnswerCall();
        }
    }
}
