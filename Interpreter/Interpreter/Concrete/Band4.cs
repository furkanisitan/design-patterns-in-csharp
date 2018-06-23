using Interpreter.Abstract;
using Interpreter.Context;
using System.Linq;

namespace Interpreter.Concrete
{
    // Term Expression Sınıf #3
    class Band4 : Expression
    {
        public override void Interpret(Resistance context)
        {
            ColorCode color = tolerances.SingleOrDefault(x => x.Color.Equals(context.Bands[3]));
            context.Output += $" %{color.Number} toleranslı";
        }
    }
}
