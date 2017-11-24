using Java.Lang;

// ReSharper disable once CheckNamespace
namespace RU.Tinkoff.Acquiring.Sdk
{
    public partial class Money
    {        
        public int CompareTo(Object o)
        {
            //return Long.valueOf(valueCoins).compareTo(o.getCoins())
            return Coins.CompareTo(((Money)o).Coins);
        }
    }
}