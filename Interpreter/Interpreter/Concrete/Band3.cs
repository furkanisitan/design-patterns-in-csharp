using Interpreter.Abstract;
using Interpreter.Context;
using System;
using System.Linq;

namespace Interpreter.Concrete
{
    // Term Expression Sınıf #2
    class Band3 : Expression
    {
        public override void Interpret(Resistance context)
        {
            ColorCode color = multipliers.FirstOrDefault(x => x.Color.Equals(context.Bands[2]));
            context.Output = (Convert.ToInt32(context.Output) * Convert.ToInt64(color.Number)) + " ohm.";
        }
    }
}
