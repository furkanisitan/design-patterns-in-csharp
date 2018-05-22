
namespace FinansLib
{
    public class TCMint : Mint
    {
        public override Money PrintMoney(int nominalValue)
        {
            return new Lira(nominalValue);
        }
    }
}
