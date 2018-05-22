
namespace FinansLib
{
    public class Lira : Money
    {
        // internal => Aynı program(dll veya exe) içerisinden erişilebilir.

        internal Lira(int nominalValue) : base(nominalValue) { }
    }
}
