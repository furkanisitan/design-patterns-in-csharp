using Interpreter.Context;

namespace Interpreter.Abstract
{
    abstract class Expression
    {
        protected ColorCode[] colors;
        protected ColorCode[] multipliers;
        protected ColorCode[] tolerances;

        public Expression()
        {
            colors = new ColorCode[] {
                new ColorCode("0","black"),
                new ColorCode("1","brown"),
                new ColorCode("2","red"),
                new ColorCode("3","orange"),
                new ColorCode("4","yellow"),
                new ColorCode("5","green"),
                new ColorCode("6","blue"),
                new ColorCode("7","purple"),
                new ColorCode("8","grey"),
                new ColorCode("9","white")
            };

            multipliers = new ColorCode[] {
                new ColorCode("1","black"),
                new ColorCode("10","brown"),
                new ColorCode("100","red"),
                new ColorCode("1000","orange"),
                new ColorCode("10000","yellow"),
                new ColorCode("100000","green"),
                new ColorCode("1000000","blue"),
                new ColorCode("10000000","purple"),
                new ColorCode("100000000","grey"),
                new ColorCode("1000000000","white")
            };

            tolerances = new ColorCode[] {
                new ColorCode("5","gold"),
                new ColorCode("10","silver"),
                new ColorCode("20","colorless")
            };
        }

        public abstract void Interpret(Resistance context);

    }
}
