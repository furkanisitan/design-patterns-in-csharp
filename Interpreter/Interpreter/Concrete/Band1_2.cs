using Interpreter.Abstract;
using Interpreter.Context;
using System.Linq;

namespace Interpreter.Concrete
{
    // Term Expression Sınıf #1
    class Band1_2 : Expression
    {
        public override void Interpret(Resistance context)
        {
            context.Output = colors.FirstOrDefault(x => x.Color.Equals(context.Bands[0])).Number +
                colors.FirstOrDefault(x => x.Color.Equals(context.Bands[1])).Number;
        }
    }
}
