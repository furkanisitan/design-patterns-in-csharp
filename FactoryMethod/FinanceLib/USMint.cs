
namespace FinansLib
{
    public class USMint : Mint
    {
        public override Money PrintMoney(int nominalValue)
        {
            return new Dolar(nominalValue);
        }
    }
}
