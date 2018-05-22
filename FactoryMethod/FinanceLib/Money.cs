
namespace FinansLib
{
    public abstract class Money
    {
        private int nominalValue;

        protected Money(int nominalValue)
        {
            this.nominalValue = nominalValue;
        }

        public string getNominalValue
        {
            get
            {
                return $"{nominalValue} {GetType().Name}";
            }
        }

    }
}
